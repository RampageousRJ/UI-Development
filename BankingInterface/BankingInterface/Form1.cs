using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BankingInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Empty case check for name-textbox
            if (this.nameTB.Text == string.Empty){
                reqname.Visible = true;
            }
            else if(this.nameTB.Text != string.Empty){
                reqname.Visible=false;
            }
            if (this.nameTB.Text.All(char.IsLetter) || this.nameTB.Text.Any(char.IsWhiteSpace)){
                nameformat.Visible = false;
            }
            else if (!this.nameTB.Text.All(char.IsLetter) || !this.nameTB.Text.Any(char.IsWhiteSpace)){
                nameformat.Visible = true;
            }

            // Empty case check for custid-textbox
            if (this.custTB.Text == string.Empty){
                reqcust.Visible = true;
            }
            else if (this.custTB.Text != string.Empty){
                reqcust.Visible = false;
            }

            // Empty case check for ipin-textbox
            if (this.ipinTB.Text == string.Empty){
                reqipin.Visible = true;
            }
            else if (this.ipinTB.Text != string.Empty){
                reqipin.Visible = false;
            }

            //Checked case for checkbox
            if (this.captcha.Checked==false){
                reqcaptcha.Visible = true;
            }
            else if (this.captcha.Checked==true){
                reqcaptcha.Visible = false;
            }

            //Validity check for date of birth; allows ages between 18 and 30
            int dateyear = dateTimePicker2.Value.Date.Year;
            int curryear = DateTime.Now.Year;
            if (curryear - 18 < dateyear){
                reqdob.Visible = true;
            }
            if (curryear - 18 >= dateyear){
                reqdob.Visible = false;
            }

            if(!reqcaptcha.Visible && !reqipin.Visible && !reqcust.Visible && !nameformat.Visible && !reqname.Visible){
                this.Hide();
                Form2 f=new Form2(nameTB.Text,custTB.Text);
                f.Show();
            }
        }
    }
}