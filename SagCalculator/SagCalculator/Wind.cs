using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagCalculator
{
    public partial class Wind : Form
    {
        public Wind()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double wc = 0;
            double ww = 0;
            double we = 0;
            double l = 0;
            double t = 0;
            double.TryParse(WTB.Text, out wc);
            double.TryParse(WwTB.Text, out ww);
            double.TryParse(LTB.Text, out l);
            double.TryParse(TTB.Text, out t);
            we = Math.Sqrt(Math.Pow(ww,2)+Math.Pow(wc,2));
            double result = ((we * l * l) / (8 * t));
            double res = (result * (wc/we));
            OP.Text = result.ToString();
            OP1.Text = res.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Wind_Load(object sender, EventArgs e)
        {

        }
    }
}
