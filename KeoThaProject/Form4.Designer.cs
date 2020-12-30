namespace KeoThaProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentInfoBox = new System.Windows.Forms.TextBox();
            this.paymentInfoBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(268, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-1, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(802, 2);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-1, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 2);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phương thức thanh toán:";
            // 
            // paymentInfoBox
            // 
            this.paymentInfoBox.Location = new System.Drawing.Point(522, 108);
            this.paymentInfoBox.Multiline = true;
            this.paymentInfoBox.Name = "paymentInfoBox";
            this.paymentInfoBox.Size = new System.Drawing.Size(195, 207);
            this.paymentInfoBox.TabIndex = 5;
            // 
            // paymentInfoBtn
            // 
            this.paymentInfoBtn.Location = new System.Drawing.Point(47, 108);
            this.paymentInfoBtn.Name = "paymentInfoBtn";
            this.paymentInfoBtn.Size = new System.Drawing.Size(75, 37);
            this.paymentInfoBtn.TabIndex = 6;
            this.paymentInfoBtn.Text = "Get info";
            this.paymentInfoBtn.UseVisualStyleBackColor = true;
            this.paymentInfoBtn.Click += new System.EventHandler(this.paymentInfoBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền phải trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(366, 380);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 33);
            this.selectBtn.TabIndex = 9;
            this.selectBtn.Text = "OK";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Electronic Wallet"});
            this.comboBox1.Location = new System.Drawing.Point(214, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentInfoBtn);
            this.Controls.Add(this.paymentInfoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paymentInfoBox;
        private System.Windows.Forms.Button paymentInfoBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}