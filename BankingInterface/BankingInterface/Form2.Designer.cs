namespace BankingInterface
{
    partial class Form2
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
            this.login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.changepin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.custidlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(183, 143);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(298, 41);
            this.login.TabIndex = 2;
            this.login.Text = "Customer Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingInterface.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(183, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 59);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.Cyan;
            this.Deposit.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deposit.Location = new System.Drawing.Point(31, 391);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(144, 42);
            this.Deposit.TabIndex = 27;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            // 
            // Withdraw
            // 
            this.Withdraw.BackColor = System.Drawing.Color.Cyan;
            this.Withdraw.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Withdraw.Location = new System.Drawing.Point(516, 391);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(144, 42);
            this.Withdraw.TabIndex = 28;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = false;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Cyan;
            this.send.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.send.Location = new System.Drawing.Point(273, 391);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(144, 42);
            this.send.TabIndex = 29;
            this.send.Text = "Send Money";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // changepin
            // 
            this.changepin.AutoSize = true;
            this.changepin.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changepin.Location = new System.Drawing.Point(296, 469);
            this.changepin.Name = "changepin";
            this.changepin.Size = new System.Drawing.Size(102, 22);
            this.changepin.TabIndex = 31;
            this.changepin.TabStop = true;
            this.changepin.Text = "Change PIN";
            this.changepin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changepin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Customer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(185, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Balance :";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.Location = new System.Drawing.Point(346, 218);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(90, 23);
            this.namelabel.TabIndex = 35;
            this.namelabel.Text = "Rishabh";
            // 
            // custidlabel
            // 
            this.custidlabel.AutoSize = true;
            this.custidlabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custidlabel.Location = new System.Drawing.Point(346, 269);
            this.custidlabel.Name = "custidlabel";
            this.custidlabel.Size = new System.Drawing.Size(209, 23);
            this.custidlabel.TabIndex = 36;
            this.custidlabel.Text = "IDGAF22XXXXXX87";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(346, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "0.00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.custidlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changepin);
            this.Controls.Add(this.send);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Name = "Form2";
            this.Text = "Account Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label login;
        private PictureBox pictureBox1;
        private Button Deposit;
        private Button Withdraw;
        private Button send;
        private LinkLabel changepin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label namelabel;
        private Label custidlabel;
        private Label label6;
    }
}