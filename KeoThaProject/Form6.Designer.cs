namespace KeoThaProject
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EWalletNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EWalletNumber,
            this.name,
            this.balance});
            this.dataGridView1.Location = new System.Drawing.Point(329, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(518, 59);
            this.dataGridView1.TabIndex = 3;
            // 
            // EWalletNumber
            // 
            this.EWalletNumber.HeaderText = "Wallet Number";
            this.EWalletNumber.MinimumWidth = 8;
            this.EWalletNumber.Name = "EWalletNumber";
            this.EWalletNumber.Width = 150;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.Pay);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 454);
            this.panel1.TabIndex = 2;
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.Chartreuse;
            this.Pay.Location = new System.Drawing.Point(16, 135);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(94, 34);
            this.Pay.TabIndex = 14;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show info";
            this.button1.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your EWallet number: ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWalletNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button Pay;
    }
}