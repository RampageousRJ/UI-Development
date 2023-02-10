using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Function to check if a given string consists of only numbers
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == string.Empty){
                label4.Visible = true;
            }
            if (this.textBox1.Text != string.Empty){
                label4.Visible = false;
            }

            //Validity check for phone number field
            if (this.textBox4.Text == string.Empty){
                invalidphone.Visible = false;
                label11.Visible = true;
            }
            else if (this.textBox4.Text != string.Empty){
                label11.Visible = false;
            }
            if(label11.Visible==false && ((!IsNumeric(this.textBox4.Text)) || (this.textBox4.Text.Length<10))){
                invalidphone.Visible = true;
            }
            if (IsNumeric(this.textBox4.Text) && this.textBox4.Text.Length >= 10)
            {
                invalidphone.Visible = false;
            }
            
            //Validity check for email address field 
            if (this.textBox3.Text == string.Empty){
                invalidmail.Visible = false;
                label10.Visible = true;
            }
            else if (this.textBox3.Text != string.Empty){
                label10.Visible = false;
            }
            if((!this.textBox3.Text.Contains(".com") || !this.textBox3.Text.Contains("@")) && label10.Visible==false){
                invalidmail.Visible = true;
            }
            else if (this.textBox3.Text.Contains(".com") && this.textBox3.Text.Contains("@"))
            {
                invalidmail.Visible = false;
            }

            if (checkBox1.Checked != true){
                label8.Visible = true;
            }
            if (checkBox1.Checked == true)
            {
                label8.Visible = false;
            }
            if (comboBox1.SelectedIndex <= -1){
                label12.Visible = true;
            }
            if (comboBox1.SelectedIndex > -1){
                label12.Visible = false;
            }
            if (comboBox2.SelectedIndex <= -1){
                label6.Visible = true;
            }
            if (comboBox2.SelectedIndex > -1){
                label6.Visible = false;
            }

            //Validity check for date of birth; allows ages between 18 and 30
            int dateyear = dateTimePicker1.Value.Date.Year;
            int curryear = DateTime.Now.Year;
            if (curryear - 18 < dateyear || curryear-30 >= dateyear){
                label9.Visible = true;
            }
            if (curryear - 18 >= dateyear && curryear - 30 < dateyear)
            {
                label9.Visible = false;
            }

            //Message box display functionalities
            if(label9.Visible==false && label6.Visible == false && label12.Visible == false && label8.Visible == false && label10.Visible == false && label11.Visible == false && label4.Visible == false && invalidphone.Visible==false && invalidmail.Visible==false){
                DialogResult dr = MessageBox.Show("Confirm?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes){
                    this.Close();
                }
                else{
                    new Form1();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void invalidphone_Click(object sender, EventArgs e)
        {

        }
    }
}
