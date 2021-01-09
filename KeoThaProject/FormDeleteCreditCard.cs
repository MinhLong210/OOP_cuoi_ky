using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class FormDeleteCreditCard : Form
    {
        public FormDeleteCreditCard()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\Admin\Documents\TaiLieuHoc\OOP\KeoThaProject\client_data.json");
            dynamic array = JsonConvert.DeserializeObject(json);
            string name = textBox1.Text;

            for(int i= 0; i < array["credit_card"]["info"].Count; i++)
            {
                if(array["credit_card"]["info"][i]["name"]==name)
                {
                    array["credit_card"]["info"][i].Remove("name");
                }    
            }
        }
    }
}
