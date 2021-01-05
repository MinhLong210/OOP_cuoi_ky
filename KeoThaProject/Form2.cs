using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string path = Directory.GetCurrentDirectory();
            string p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25;
            p1 = path + @"\image\table1.png";
            p2 = path + @"\image\chair1.png";
            current = 0;
            listIm = new List<Image>();
            listPrice = new List<int>();
            listIm.Add(Image.FromFile(p1));
            listPrice.Add(200);
            listIm.Add(Image.FromFile(p2));
            listPrice.Add(100);
            pictureBox1.Image = listIm[0];
            priceLabel.Text = listPrice[0].ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            current++;
            current = Math.Abs(current);
            current = Math.Abs(current);
            pictureBox1.Image = listIm[current % (listIm.Count)];
            priceLabel.Text = listPrice[current % (listPrice.Count)].ToString();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            current--;
            current = Math.Abs(current);
            current = Math.Abs(current);
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
