namespace SagCalculator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.conductorbutton = new System.Windows.Forms.Button();
            this.windbutton = new System.Windows.Forms.Button();
            this.icebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sag Calculator";
            // 
            // conductorbutton
            // 
            this.conductorbutton.Location = new System.Drawing.Point(197, 200);
            this.conductorbutton.Name = "conductorbutton";
            this.conductorbutton.Size = new System.Drawing.Size(197, 67);
            this.conductorbutton.TabIndex = 3;
            this.conductorbutton.Text = "Conductor Weight Only";
            this.conductorbutton.UseVisualStyleBackColor = true;
            this.conductorbutton.Click += new System.EventHandler(this.conductorbutton_Click);
            // 
            // windbutton
            // 
            this.windbutton.Location = new System.Drawing.Point(197, 311);
            this.windbutton.Name = "windbutton";
            this.windbutton.Size = new System.Drawing.Size(197, 67);
            this.windbutton.TabIndex = 4;
            this.windbutton.Text = "Effect of Wind on Sag";
            this.windbutton.UseVisualStyleBackColor = true;
            this.windbutton.Click += new System.EventHandler(this.windbutton_Click);
            // 
            // icebutton
            // 
            this.icebutton.Location = new System.Drawing.Point(197, 425);
            this.icebutton.Name = "icebutton";
            this.icebutton.Size = new System.Drawing.Size(197, 67);
            this.icebutton.TabIndex = 5;
            this.icebutton.Text = "Effect of Ice Coating on Sag";
            this.icebutton.UseVisualStyleBackColor = true;
            this.icebutton.Click += new System.EventHandler(this.icebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SagCalculator.Properties.Resources.register1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 601);
            this.Controls.Add(this.icebutton);
            this.Controls.Add(this.windbutton);
            this.Controls.Add(this.conductorbutton);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Sag Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conductorbutton;
        private System.Windows.Forms.Button windbutton;
        private System.Windows.Forms.Button icebutton;
    }
}

