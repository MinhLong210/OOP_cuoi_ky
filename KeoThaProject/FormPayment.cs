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
    public partial class FormPayment : Form
    {
        Dictionary<string, int> addedRooms;
        Dictionary<string, int> addedItems;
        public int paymentAmount;
        
        public FormPayment(Dictionary<string, int> rooms, Dictionary<string, int> items)
        {
            InitializeComponent();
            paymentAmount = 0;
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
            int pam;
            public PaymentCreditCard(int Pam) {
                pam = Pam;
            }
            public override void getResult()
            {
                FormCreditCard f5 = new FormCreditCard(pam);
                f5.Show();   
            }
        }
        public class PaymentEWallet : Payment
        {
            int pam;
            public PaymentEWallet(int Pam) {
                pam = Pam;
            }
           
            public override void getResult()
            {
                FormEWallet f6 = new FormEWallet(pam);
                f6.Show();
            }
        }

        public class PaymentFactory
        {
            protected string paymentType;
            protected int pam;
            public PaymentFactory(string type, int Pam)
            {
                paymentType = type;
                pam = Pam;
            }
            
            public Payment createPaymentMethod()
            {
                if (paymentType == "Cash")
                    return new PaymentCash();
                if (paymentType == "Credit Card")
                    return new PaymentCreditCard(pam);
                if (paymentType == "Electronic Wallet")
                    return new PaymentEWallet(pam);
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
                    PaymentFactory paymentFactoryCC = new PaymentFactory("Credit Card", paymentAmount);
                    Payment paymentMethodCC = paymentFactoryCC.createPaymentMethod();
                    paymentMethodCC.getResult();
                    break;
                case "Electronic Wallet":
                    PaymentFactory paymentFactoryE = new PaymentFactory("Electronic Wallet", paymentAmount);
                    Payment paymentMethodE = paymentFactoryE.createPaymentMethod();
                    paymentMethodE.getResult();
                    break;
                case "Cash":
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn một phương thức thanh toán có sẵn");
                    break;

            }    
        }
        
    }
}
