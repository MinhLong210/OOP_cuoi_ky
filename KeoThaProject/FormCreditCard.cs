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
    public partial class FormCreditCard : Form
    {
        List<string> clientIDList = new List<string>();
        List<string> clientNameList = new List<string>();
        List<string> clientBalanceList = new List<string>();
        int paymentAmount;
        string json;
        dynamic array;
        public FormCreditCard(int amount)
        {
            InitializeComponent();
         
            //StreamReader r = new StreamReader(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
            
             json = File.ReadAllText(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
             array = JsonConvert.DeserializeObject(json);
        
            foreach(var item in array["credit_card"]["info"])
            {
                //MessageBox.Show((item["id"]).ToString());
                clientIDList.Add((item["id"]).ToString());
                clientNameList.Add((item["name"]).ToString());
                clientBalanceList.Add((item["balance"]).ToString());
            }
            paymentAmount = amount;
        }
        public class ClientInfo
        {
            string ID;
            string name;
            string balance;
            public ClientInfo(string id, string na, string bal)
            {
                ID = id;
                name = na;
                balance = bal;
            }
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                int clientIndex = -1;
                for(int i=0; i< array["credit_card"]["info"].Count; i++)
                {
                    if(array["credit_card"]["info"][i]["id"]==idBox.Text)
                    {
                        clientIndex = i;
                        break;
                    }    
                }    
                if (clientIndex != -1)
                {
                    int moneyLeft = int.Parse(array["credit_card"]["info"][clientIndex]["balance"].ToString()) - paymentAmount;
                    if (moneyLeft < 0)
                        MessageBox.Show("Không đủ tiền trả: ");
                    else
                    {
                        clientBalanceList[clientIndex] = moneyLeft.ToString();

                        array["credit_card"]["info"][clientIndex]["balance"] = moneyLeft.ToString();
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






        private void AddDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void PaymentInfoBtn_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show(clientIDList.Count.ToString());
            for(int i=0; i < array["credit_card"]["info"].Count; i++)
            {
                i = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = clientIDList[i];
                dataGridView1.Rows[i].Cells[2].Value = clientNameList[i];
                dataGridView1.Rows[i].Cells[3].Value = clientBalanceList[i];

            }   
            */
            try
            {
                int clientIndex = -1;
                for (int i = 0; i < array["credit_card"]["info"].Count; i++)
                {
                    if (array["credit_card"]["info"][i]["id"] == idBox.Text)
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
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FormDeleteCreditCard f = new FormDeleteCreditCard();
            f.Show();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            FormChangeCreditCard f = new FormChangeCreditCard();
            f.Show();
        }
    }
}
