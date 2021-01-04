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
    public partial class Form3 : Form
    {
        List<Image> listIm;
        List<int> listPrice;
        private int current;
        public Image returnIm;
        public string returnName;
        
        #region payment
        public int returnPrice;
        #endregion

        public Form3()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();

            current = 0;
            listIm = new List<Image>();
            #region payment
            listPrice = new List<int>();
            #endregion
            string background1Path = path + @"\image\background1.png";
            string background2Path = path + @"\image\background2.png";

            listIm.Add(Image.FromFile(background1Path));
            listPrice.Add(1000);

            listIm.Add(Image.FromFile(background2Path));
            listPrice.Add(1500);
            pictureBox1.Image = listIm[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            current--;
            pictureBox1.Image = listIm[current % (listIm.Count)];
            priceLabel.Text = listPrice[current % (listPrice.Count)].ToString();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            current++;
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
