using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeoThaProject
{
    public partial class Form2 : Form
    {
        List<Image> listIm;
        List<int> listPrice;
        private int current;
        public Image returnIm;
        public string returnName;

        #region payment
        public int returnPrice;
        #endregion
        public Form2()
        {
            InitializeComponent();
            current = 0;
            listIm = new List<Image>();
            listPrice = new List<int>();
            listIm.Add(Image.FromFile(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\image\table1.png"));
            listPrice.Add(200);
            listIm.Add(Image.FromFile(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\image\chair1.png"));
            listPrice.Add(100);
            pictureBox1.Image = listIm[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            current++;
            pictureBox1.Image = listIm[current % (listIm.Count)];
            priceLabel.Text = listPrice[current % (listPrice.Count)].ToString();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            current--;
            pictureBox1.Image = listIm[current % (listIm.Count)];
            priceLabel.Text = listPrice[current % (listPrice.Count)].ToString();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.returnIm = listIm[current % (listIm.Count)];
            this.returnName = textBox1.Text.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            #region payment
            returnPrice = int.Parse(priceLabel.Text);
            #endregion

            this.Close();

        }
    }
}
