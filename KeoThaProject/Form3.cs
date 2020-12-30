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
            current = 0;
            listIm = new List<Image>();
            #region payment
            listPrice = new List<int>();
            #endregion
            listIm.Add(Image.FromFile(@"D:\CODE\C#\KeoThaProject\image\background1.png"));
            listPrice.Add(1000);

            listIm.Add(Image.FromFile(@"D:\CODE\C#\KeoThaProject\image\background2.jpg"));
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
