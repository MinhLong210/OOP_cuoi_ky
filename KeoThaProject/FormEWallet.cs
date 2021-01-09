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
    public partial class FormEWallet : Form
    {
        List<string> clientIDList = new List<string>();
        List<string> clientNameList = new List<string>();
        List<string> clientBalanceList = new List<string>();
        int paymentAmount;
        string json;
        dynamic array;
        public FormEWallet(int amount)
        {
            InitializeComponent();

            //StreamReader r = new StreamReader(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");

            json = File.ReadAllText(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
            array = JsonConvert.DeserializeObject(json);

            foreach (var item in array["EWallet"]["info"])
            {
                //MessageBox.Show((item["id"]).ToString());
                clientIDList.Add((item["id"]).ToString());
                clientNameList.Add((item["name"]).ToString());
                clientBalanceList.Add((item["balance"]).ToString());
            }
            paymentAmount = amount;
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                int clientIndex = -1;
                for (int i = 0; i < array["EWallet"]["info"].Count; i++)
                {
                    if (array["EWallet"]["info"][i]["id"] == idBox.Text)
                    {
                        clientIndex = i;
                        break;
                    }
                }
                if (clientIndex != -1)
                {
                    int moneyLeft = int.Parse(array["EWallet"]["info"][clientIndex]["balance"].ToString()) - paymentAmount;
                    if (moneyLeft < 0)
                        MessageBox.Show("Không đủ tiền trả: ");
                    else
                    {
                        clientBalanceList[clientIndex] = moneyLeft.ToString();

                        array["EWallet"]["info"][clientIndex]["balance"] = moneyLeft.ToString();
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText("C:\\Users\\Admin\\Documents\\TaiLieuHoc\\OOP\\KeoThaProject\\client_data.json", output);

                        MessageBox.Show("Số tiền còn lại: " + moneyLeft.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại id này");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void paymentInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int clientIndex = clientIDList.IndexOf(idBox.Text);
                //MessageBox.Show(array["credit_card"]["info"][clientIndex]["name"].ToString());
                //MessageBox.Show(array["credit_card"]["info"][clientIndex]["balance"].ToString());
                if (clientIndex != -1)
                {
                    int index = this.dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = array["EWallet"]["info"][clientIndex]["id"].ToString();
                    dataGridView1.Rows[index].Cells[1].Value = array["EWallet"]["info"][clientIndex]["name"].ToString();
                    dataGridView1.Rows[index].Cells[2].Value = array["EWallet"]["info"][clientIndex]["balance"].ToString();
                }
                else
                {
                   MessageBox.Show("Không tồn tại id này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
