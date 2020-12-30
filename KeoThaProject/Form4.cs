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
        }

        public abstract class Payment
        {
            public Payment() { }
            public abstract int getResult();
        }

        public class PaymentCash: Payment
        {
            public PaymentCash() { }
            public override int getResult()
            {
                return 0;
            }
        }
        public class PaymentCreditCard : Payment
        {
            public PaymentCreditCard() { }
            public override int getResult()
            {
                return 0;
            }
        }
        public class PaymentEWallet : Payment
        {
            public PaymentEWallet() { }
            public override int getResult()
            {
                return 0;
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
        
        private void paymentInfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(addedItems.Count().ToString());
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
