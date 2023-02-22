namespace BankingInterface
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
            this.login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameformat = new System.Windows.Forms.Label();
            this.reqcust = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.RichTextBox();
            this.custTB = new System.Windows.Forms.RichTextBox();
            this.custid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(182, 111);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(215, 41);
            this.login.TabIndex = 41;
            this.login.Text = "Send Money";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingInterface.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(159, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 59);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // nameformat
            // 
            this.nameformat.AutoSize = true;
            this.nameformat.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameformat.ForeColor = System.Drawing.Color.Red;
            this.nameformat.Location = new System.Drawing.Point(162, 364);
            this.nameformat.Name = "nameformat";
            this.nameformat.Size = new System.Drawing.Size(151, 20);
            this.nameformat.TabIndex = 48;
            this.nameformat.Text = "*invalid name format";
            this.nameformat.UseWaitCursor = true;
            this.nameformat.Visible = false;
            // 
            // reqcust
            // 
            this.reqcust.AutoSize = true;
            this.reqcust.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqcust.ForeColor = System.Drawing.Color.Red;
            this.reqcust.Location = new System.Drawing.Point(209, 247);
            this.reqcust.Name = "reqcust";
            this.reqcust.Size = new System.Drawing.Size(104, 20);
            this.reqcust.TabIndex = 46;
            this.reqcust.Text = "*required field";
            this.reqcust.Visible = false;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTB.Location = new System.Drawing.Point(44, 334);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(269, 27);
            this.nameTB.TabIndex = 45;
            this.nameTB.Text = "";
            // 
            // custTB
            // 
            this.custTB.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custTB.Location = new System.Drawing.Point(44, 217);
            this.custTB.Name = "custTB";
            this.custTB.Size = new System.Drawing.Size(269, 27);
            this.custTB.TabIndex = 43;
            this.custTB.Text = "";
            // 
            // custid
            // 
            this.custid.AutoSize = true;
            this.custid.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custid.Location = new System.Drawing.Point(89, 190);
            this.custid.Name = "custid";
            this.custid.Size = new System.Drawing.Size(171, 24);
            this.custid.TabIndex = 42;
            this.custid.Text = "Beneficiary Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Beneficiary Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(453, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Amount";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(443, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(109, 27);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = "";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Cyan;
            this.confirm.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm.Location = new System.Drawing.Point(443, 378);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(109, 42);
            this.confirm.TabIndex = 53;
            this.confirm.Text = "Send";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 475);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameformat);
            this.Controls.Add(this.reqcust);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.custTB);
            this.Controls.Add(this.custid);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label login;
        private PictureBox pictureBox1;
        private Label nameformat;
        private Label reqcust;
        private RichTextBox nameTB;
        private RichTextBox custTB;
        private Label custid;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button confirm;
    }
}