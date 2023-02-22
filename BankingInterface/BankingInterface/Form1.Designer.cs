namespace BankingInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Label();
            this.custTB = new System.Windows.Forms.RichTextBox();
            this.custid = new System.Windows.Forms.Label();
            this.ipinTB = new System.Windows.Forms.RichTextBox();
            this.IPIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.captcha = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.forgotipin = new System.Windows.Forms.LinkLabel();
            this.forgotcust = new System.Windows.Forms.LinkLabel();
            this.nameTB = new System.Windows.Forms.RichTextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.reqcust = new System.Windows.Forms.Label();
            this.reqname = new System.Windows.Forms.Label();
            this.reqipin = new System.Windows.Forms.Label();
            this.reqcaptcha = new System.Windows.Forms.Label();
            this.reqdob = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nameformat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(380, 117);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 41);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            // 
            // custTB
            // 
            this.custTB.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custTB.Location = new System.Drawing.Point(58, 218);
            this.custTB.Name = "custTB";
            this.custTB.Size = new System.Drawing.Size(303, 27);
            this.custTB.TabIndex = 5;
            this.custTB.Text = "";
            // 
            // custid
            // 
            this.custid.AutoSize = true;
            this.custid.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custid.Location = new System.Drawing.Point(58, 191);
            this.custid.Name = "custid";
            this.custid.Size = new System.Drawing.Size(174, 24);
            this.custid.TabIndex = 4;
            this.custid.Text = "Enter CustomerID";
            // 
            // ipinTB
            // 
            this.ipinTB.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipinTB.Location = new System.Drawing.Point(517, 218);
            this.ipinTB.Name = "ipinTB";
            this.ipinTB.Size = new System.Drawing.Size(303, 27);
            this.ipinTB.TabIndex = 7;
            this.ipinTB.Text = "";
            // 
            // IPIN
            // 
            this.IPIN.AutoSize = true;
            this.IPIN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPIN.Location = new System.Drawing.Point(517, 191);
            this.IPIN.Name = "IPIN";
            this.IPIN.Size = new System.Drawing.Size(107, 24);
            this.IPIN.TabIndex = 6;
            this.IPIN.Text = "Enter IPIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(517, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Date Of Birth";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(517, 333);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(303, 26);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // captcha
            // 
            this.captcha.AutoSize = true;
            this.captcha.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captcha.Location = new System.Drawing.Point(363, 413);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(152, 26);
            this.captcha.TabIndex = 12;
            this.captcha.Text = "I am not a robot";
            this.captcha.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Cyan;
            this.submit.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit.Location = new System.Drawing.Point(363, 455);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(144, 42);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // forgotipin
            // 
            this.forgotipin.AutoSize = true;
            this.forgotipin.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotipin.Location = new System.Drawing.Point(722, 248);
            this.forgotipin.Name = "forgotipin";
            this.forgotipin.Size = new System.Drawing.Size(94, 20);
            this.forgotipin.TabIndex = 16;
            this.forgotipin.TabStop = true;
            this.forgotipin.Text = "Forgot IPIN?";
            // 
            // forgotcust
            // 
            this.forgotcust.AutoSize = true;
            this.forgotcust.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotcust.Location = new System.Drawing.Point(211, 248);
            this.forgotcust.Name = "forgotcust";
            this.forgotcust.Size = new System.Drawing.Size(145, 20);
            this.forgotcust.TabIndex = 17;
            this.forgotcust.TabStop = true;
            this.forgotcust.Text = "Forgot CustomerID?";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTB.Location = new System.Drawing.Point(58, 335);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(303, 27);
            this.nameTB.TabIndex = 19;
            this.nameTB.Text = "";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.Location = new System.Drawing.Point(58, 308);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(119, 24);
            this.namelabel.TabIndex = 18;
            this.namelabel.Text = "Enter Name";
            // 
            // reqcust
            // 
            this.reqcust.AutoSize = true;
            this.reqcust.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqcust.ForeColor = System.Drawing.Color.Red;
            this.reqcust.Location = new System.Drawing.Point(252, 194);
            this.reqcust.Name = "reqcust";
            this.reqcust.Size = new System.Drawing.Size(104, 20);
            this.reqcust.TabIndex = 20;
            this.reqcust.Text = "*required field";
            this.reqcust.Visible = false;
            // 
            // reqname
            // 
            this.reqname.AutoSize = true;
            this.reqname.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqname.ForeColor = System.Drawing.Color.Red;
            this.reqname.Location = new System.Drawing.Point(252, 311);
            this.reqname.Name = "reqname";
            this.reqname.Size = new System.Drawing.Size(104, 20);
            this.reqname.TabIndex = 21;
            this.reqname.Text = "*required field";
            this.reqname.Visible = false;
            // 
            // reqipin
            // 
            this.reqipin.AutoSize = true;
            this.reqipin.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqipin.ForeColor = System.Drawing.Color.Red;
            this.reqipin.Location = new System.Drawing.Point(722, 195);
            this.reqipin.Name = "reqipin";
            this.reqipin.Size = new System.Drawing.Size(104, 20);
            this.reqipin.TabIndex = 22;
            this.reqipin.Text = "*required field";
            this.reqipin.Visible = false;
            // 
            // reqcaptcha
            // 
            this.reqcaptcha.AutoSize = true;
            this.reqcaptcha.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqcaptcha.ForeColor = System.Drawing.Color.Red;
            this.reqcaptcha.Location = new System.Drawing.Point(527, 416);
            this.reqcaptcha.Name = "reqcaptcha";
            this.reqcaptcha.Size = new System.Drawing.Size(144, 20);
            this.reqcaptcha.TabIndex = 24;
            this.reqcaptcha.Text = "*captcha unchecked";
            this.reqcaptcha.Visible = false;
            // 
            // reqdob
            // 
            this.reqdob.AutoSize = true;
            this.reqdob.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqdob.ForeColor = System.Drawing.Color.Red;
            this.reqdob.Location = new System.Drawing.Point(722, 307);
            this.reqdob.Name = "reqdob";
            this.reqdob.Size = new System.Drawing.Size(88, 20);
            this.reqdob.TabIndex = 23;
            this.reqdob.Text = "*invalid age";
            this.reqdob.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingInterface.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(303, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 59);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Not already a customer?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(71, 439);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 20);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register here";
            // 
            // nameformat
            // 
            this.nameformat.AutoSize = true;
            this.nameformat.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameformat.ForeColor = System.Drawing.Color.Red;
            this.nameformat.Location = new System.Drawing.Point(210, 312);
            this.nameformat.Name = "nameformat";
            this.nameformat.Size = new System.Drawing.Size(151, 20);
            this.nameformat.TabIndex = 28;
            this.nameformat.Text = "*invalid name format";
            this.nameformat.UseWaitCursor = true;
            this.nameformat.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(893, 527);
            this.Controls.Add(this.nameformat);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reqcaptcha);
            this.Controls.Add(this.reqdob);
            this.Controls.Add(this.reqipin);
            this.Controls.Add(this.reqname);
            this.Controls.Add(this.reqcust);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.forgotcust);
            this.Controls.Add(this.forgotipin);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipinTB);
            this.Controls.Add(this.IPIN);
            this.Controls.Add(this.custTB);
            this.Controls.Add(this.custid);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "IDGAF Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label login;
        private RichTextBox custTB;
        private Label custid;
        private RichTextBox ipinTB;
        private Label IPIN;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private CheckBox captcha;
        private Button submit;
        private LinkLabel forgotipin;
        private LinkLabel forgotcust;
        private RichTextBox nameTB;
        private Label namelabel;
        private Label reqcust;
        private Label reqname;
        private Label reqipin;
        private Label reqcaptcha;
        private Label reqdob;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label nameformat;
    }
}