namespace KeoThaProject
{
    partial class FormCreditCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pay = new System.Windows.Forms.Button();
            this.PaymentInfoBtn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDataBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.Pay);
            this.panel1.Controls.Add(this.PaymentInfoBtn);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 454);
            this.panel1.TabIndex = 0;
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.Chartreuse;
            this.Pay.Location = new System.Drawing.Point(16, 126);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(94, 34);
            this.Pay.TabIndex = 13;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // PaymentInfoBtn
            // 
            this.PaymentInfoBtn.Location = new System.Drawing.Point(169, 46);
            this.PaymentInfoBtn.Name = "PaymentInfoBtn";
            this.PaymentInfoBtn.Size = new System.Drawing.Size(75, 50);
            this.PaymentInfoBtn.TabIndex = 2;
            this.PaymentInfoBtn.Text = "Show info";
            this.PaymentInfoBtn.UseVisualStyleBackColor = true;
            this.PaymentInfoBtn.Click += new System.EventHandler(this.PaymentInfoBtn_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(16, 58);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(131, 26);
            this.idBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.balance});
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(518, 121);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.MinimumWidth = 8;
            this.balance.Name = "balance";
            this.balance.Width = 150;
            // 
            // AddDataBtn
            // 
            this.AddDataBtn.Location = new System.Drawing.Point(896, 33);
            this.AddDataBtn.Name = "AddDataBtn";
            this.AddDataBtn.Size = new System.Drawing.Size(75, 38);
            this.AddDataBtn.TabIndex = 2;
            this.AddDataBtn.Text = "Add";
            this.AddDataBtn.UseVisualStyleBackColor = true;
            this.AddDataBtn.Click += new System.EventHandler(this.AddDataBtn_Click);
            // 
            // FormCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.AddDataBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreditCard";
            this.Text = "Credit Card Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PaymentInfoBtn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button AddDataBtn;
    }
}