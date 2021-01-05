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
    public partial class Form4 : Form
    {
        Dictionary<string, int> addedRooms;
        Dictionary<string, int> addedItems;
        int paymentAmount = 0;
        
        public Form4(Dictionary<string, int> rooms, Dictionary<string, int> items)
        {
            InitializeComponent();
            addedItems = items;
            addedRooms = rooms;
            foreach (var item in addedRooms)
            {
                paymentInfoBox.Text += item.Key + " " + item.Value.ToString() + Environment.NewLine;
                paymentAmount += item.Value;
            }
            foreach (var item in addedItems)
            {
                paymentInfoBox.Text += item.Key + " " + item.Value.ToString() + Environment.NewLine;
                paymentAmount += item.Value;
            }
            label6.Text = paymentAmount.ToString();
        }

        public abstract class Payment
        {
            public Payment() { }
            public abstract void getResult();
        }

        public class PaymentCash: Payment
        {
            public PaymentCash() { }
            public override void getResult()
            {
                
            }
        }
        public class PaymentCreditCard : Payment
        {
            public PaymentCreditCard() {
            }
            public override void getResult()
            {
               
            }
        }
        public class PaymentEWallet : Payment
        {
            public PaymentEWallet() { }
            public override void getResult()
            {
                
            }
        }

        public class PaymentFactory
        {
            protected string paymentType;
            public PaymentFactory(string type)
            {
                paymentType = type;
            }
            
            public Payment createPaymentMethod()
            {
                if (paymentType == "Cash")
                    return new PaymentCash();
                if (paymentType == "Credit Card")
                    return new PaymentCreditCard();
                if (paymentType == "Electronic Wallet")
                    return new PaymentEWallet();
                else
                {
                    return new PaymentCash();
                }
            }
        }
        
        

        private void selectBtn_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "Credit Card":
                    Form5 f5 = new Form5(paymentAmount);
                    f5.Show();
                    break;
                case "Electronic Wallet":
                    Form6 f6 = new Form6(paymentAmount);
                    f6.Show();
                    break;
                    
            }    
        }
        
    }
}
