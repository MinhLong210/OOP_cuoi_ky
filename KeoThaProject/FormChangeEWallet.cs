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
using Json.Net;
using Newtonsoft.Json;

namespace KeoThaProject
{
    public partial class FormChangeEWallet : Form
    {
        public FormChangeEWallet()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
            dynamic array = JsonConvert.DeserializeObject(json);
            try
            {
                int clientIndex = -1;
                for (int i = 0; i < array["EWallet"]["info"].Count; i++)
                {
                    if (array["EWallet"]["info"][i]["id"] == textBox1.Text)
                    {
                        clientIndex = i;
                        break;
                    }
                }

                if (newNameTxtBox.Text != "")
                {
                    array["EWallet"]["info"][clientIndex]["name"] = newNameTxtBox.Text;
                    dataGridView1.Rows[clientIndex].Cells[1].Value = newNameTxtBox.Text;
                }
                if (newBalanceTxtBox.Text != "")
                {
                    array["EWallet"]["info"][clientIndex]["balance"] = newBalanceTxtBox.Text;
                    dataGridView1.Rows[clientIndex].Cells[2].Value = newBalanceTxtBox.Text;
                }
                
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("C:\\Users\\Admin\\Documents\\TaiLieuHoc\\OOP\\KeoThaProject\\client_data.json", output);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
            dynamic array = JsonConvert.DeserializeObject(json);
            try
            {
                int clientIndex = -1;
                for (int i = 0; i < array["EWallet"]["info"].Count; i++)
                {
                    if (array["EWallet"]["info"][i]["id"] == textBox1.Text)
                    {
                        clientIndex = i;
                        break;
                    }
                }
                if (clientIndex != -1)
                {
                    int index = this.dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = array["credit_card"]["info"][clientIndex]["id"].ToString();
                    dataGridView1.Rows[index].Cells[1].Value = array["credit_card"]["info"][clientIndex]["name"].ToString();
                    dataGridView1.Rows[index].Cells[2].Value = array["credit_card"]["info"][clientIndex]["balance"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tồn tại id này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
