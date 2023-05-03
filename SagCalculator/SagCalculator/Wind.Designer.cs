namespace SagCalculator
{
    partial class Wind
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
            this.calculate = new System.Windows.Forms.Button();
            this.OP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WwTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OP1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(332, 611);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(114, 36);
            this.calculate.TabIndex = 29;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // OP
            // 
            this.OP.AutoSize = true;
            this.OP.BackColor = System.Drawing.Color.Transparent;
            this.OP.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OP.Location = new System.Drawing.Point(389, 505);
            this.OP.Name = "OP";
            this.OP.Size = new System.Drawing.Size(65, 23);
            this.OP.TabIndex = 28;
            this.OP.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Maximum Sag (S):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Output";
            // 
            // WTB
            // 
            this.WTB.Location = new System.Drawing.Point(433, 346);
            this.WTB.Name = "WTB";
            this.WTB.Size = new System.Drawing.Size(173, 22);
            this.WTB.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Weight of Conductor (Wc):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Effect of Wind on Sag";
            // 
            // TTB
            // 
            this.TTB.Location = new System.Drawing.Point(433, 299);
            this.TTB.Name = "TTB";
            this.TTB.Size = new System.Drawing.Size(173, 22);
            this.TTB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Working Tension (T): ";
            // 
            // LTB
            // 
            this.LTB.Location = new System.Drawing.Point(433, 250);
            this.LTB.Name = "LTB";
            this.LTB.Size = new System.Drawing.Size(173, 22);
            this.LTB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Horizontal Span (L): ";
            // 
            // WwTB
            // 
            this.WwTB.Location = new System.Drawing.Point(433, 395);
            this.WwTB.Name = "WwTB";
            this.WwTB.Size = new System.Drawing.Size(173, 22);
            this.WwTB.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Wind Loading (Ww):";
            // 
            // OP1
            // 
            this.OP1.AutoSize = true;
            this.OP1.BackColor = System.Drawing.Color.Transparent;
            this.OP1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OP1.Location = new System.Drawing.Point(389, 556);
            this.OP1.Name = "OP1";
            this.OP1.Size = new System.Drawing.Size(65, 23);
            this.OP1.TabIndex = 33;
            this.OP1.Text = "NULL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Vertical Sag (Sv):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = "Back";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::SagCalculator.Properties.Resources.backicon1;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(85, 59);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 34);
            this.back.TabIndex = 56;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Wind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SagCalculator.Properties.Resources.register1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 721);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.back);
            this.Controls.Add(this.OP1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WwTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.OP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LTB);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Wind";
            this.Text = "Wind";
            this.Load += new System.EventHandler(this.Wind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label OP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WwTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label OP1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox back;
    }
}