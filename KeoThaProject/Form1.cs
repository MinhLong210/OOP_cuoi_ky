using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeoThaProject
{
    public partial class Form1 : Form
    {
        Composite CpMainHouse = new Composite("Main house");
        TreeNode TnMainHouse = new TreeNode("Main house");
        Bitmap bm1,bm2;
        Graphics g;
        Image curIm;
        string path = Directory.GetCurrentDirectory();

        #region 
        int curPrice;
        public Dictionary<string, int> addedRooms = new Dictionary<string, int>();
        public Dictionary<string, int> addedItems = new Dictionary<string, int>();
        #endregion

        List<Leaf> curRoom;
        Composite curComposite;
        TreeNode curNode;
        Point curLocation;
        bool drawing;
        string curName;
        public abstract class Component
        {
            public string name;
            public Point location;
            public Image Im;

            #region payment
            public int cost;
            #endregion

            public Component(string name)
            {
                this.name = name;
            }
            public Component(string name, Point p, Image Im, int cost)
            {
                this.name = name;
                this.location = p;
                this.Im = Im;
                this.cost = cost;
            }
            public virtual void add(Component component) { }
            public virtual void remove(Component component) { }
        }

        public class Composite : Component
        {
            public List<Component> list = new List<Component>();
            public Composite(string name) : base(name) { }
            public Composite(string name,Point p,Image Im, int price) : base(name,p,Im, price) { }
            public override void add(Component component)
            {
                list.Add(component);
            }
            public override void remove(Component component)
            {
                list.Remove(component);
            }
        }
        public class Leaf : Component
        {
            public Leaf(string n) : base(n) { }
            public Leaf(string name, Point p, Image Im, int price) : base(name, p, Im, price) { }
            public override void add(Component component)
            {
                return;
            }
            public override void remove(Component component)
            {
                return;
            }
        }
        public Form1()
        {
            InitializeComponent();
            string background1Path = path + @"\image\background1.png";
            pictureBox.BackgroundImage = Image.FromFile(background1Path);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            curRoom = new List<Leaf>();

            drawing = false;

            bm1 = new Bitmap(pictureBox.Width, pictureBox.Height);
            bm2 = new Bitmap(pictureBox.Width, pictureBox.Height);

            CpMainHouse.Im = Image.FromFile(background1Path);
            treeView1.Nodes.Add(TnMainHouse);
            LoadTree(CpMainHouse, TnMainHouse);
        }

        private void LoadTree(Component component, TreeNode TR)
        {

            if(component is Composite)
            {
                Composite composite = (Composite)component;
                TR.Tag = composite;
                foreach (Component component2 in composite.list)
                {
                    TreeNode tempponent = new TreeNode() { Text = component2.name };
                    TR.Nodes.Add(tempponent);
                    LoadTree(component2, tempponent);
                }
            }
            else
            {
                TR.Tag = component;    // o day la leaf
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            drawing = false;
            TreeNode newNodeRoom = new TreeNode();
            try
            {
                if(treeView1.SelectedNode.Tag is Composite)
                {
                    Composite composite = (Composite)treeView1.SelectedNode.Tag;

                    using (Form3 f3 = new Form3())
                    {
                        if (f3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            Composite newRoom = new Composite(f3.returnName, new Point(0, 0), f3.returnIm, f3.returnPrice);
                            composite.add(newRoom);
                            newNodeRoom.Text = f3.returnName;
                            newNodeRoom.Tag = newRoom;
                            treeView1.SelectedNode.Nodes.Add(newNodeRoom);

                            #region
                            addedRooms.Add(f3.returnName, f3.returnPrice);
                            #endregion
                        }
                    }
                }
            }
            catch
            {
                treeView1.Nodes.Add(newNodeRoom);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Parent == null)   // Khong xoa duoc thang goc
            {
                return;
            }
            if(treeView1.SelectedNode.Parent.Tag is Composite)
            {
                Composite composite = (Composite)treeView1.SelectedNode.Parent.Tag;
                composite.remove((Component)treeView1.SelectedNode.Tag);
                treeView1.SelectedNode.Remove();
                Update();
            }
        }
        private void AddItem_Click(object sender, EventArgs e)
        {
            Update();
            drawing = true;
            try
            {
                if (treeView1.SelectedNode.Tag is Composite)
                {
                    curComposite = (Composite)treeView1.SelectedNode.Tag;

                    using (Form2 f2 = new Form2())
                    {
                        if (f2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            curIm = f2.returnIm;
                            curName = f2.returnName;
                            curNode = new TreeNode(curName);
                            addedItems.Add(f2.returnName, f2.returnPrice);

                        }
                    }
                }
            }
            catch
            {
                try
                {
                    treeView1.Nodes.Add(curNode);
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            bm2 = (Bitmap)bm1.Clone();
            g = Graphics.FromImage(bm2);
            if (drawing)
            {
                try
                {
                    g.DrawImage(curIm, e.Location);
                }
                catch
                {
                    return;
                }
                pictureBox.Image = bm2;
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                curLocation = e.Location;
                bm1 = (Bitmap)bm2.Clone();
                Leaf newItem = new Leaf(curName, curLocation, curIm, curPrice);
                curComposite.add(newItem);
                curNode.Tag = newItem;
                treeView1.SelectedNode.Nodes.Add(curNode);
                drawing = false;
            }
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            Form4 paymentForm = new Form4(addedRooms, addedItems);
            paymentForm.Show();
        }

        private void Update()
        {
            curRoom.Clear();
            Composite composite = new Composite(null,new Point(0,0),null,0);
            if (treeView1.SelectedNode.Tag is Composite)
            {
                composite = (Composite)treeView1.SelectedNode.Tag;
            }
            else if(treeView1.SelectedNode.Tag is Leaf)
            {
                composite = (Composite)treeView1.SelectedNode.Parent.Tag;
            }
            pictureBox.BackgroundImage = composite.Im;
            foreach (Component c in composite.list)
            {
                if (c is Leaf)
                {
                    Leaf leaf = (Leaf)c;
                    curRoom.Add(leaf);
                }
                else
                {
                    continue;
                }
            }
            Draw();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            drawing = false;
            if(treeView1.SelectedNode.Tag is Composite)
            {
                Update();
            }
        }

        private void Draw()
        {
            bm1 = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bm1);
            foreach (Leaf leaf in curRoom)
            {
                g.DrawImage(leaf.Im, leaf.location);
            }
            pictureBox.Image = bm1;
        }

    }
}
