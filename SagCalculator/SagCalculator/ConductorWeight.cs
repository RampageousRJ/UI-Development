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
    public partial class ConductorWeight : Form
    {
        public ConductorWeight()
        {
            InitializeComponent();
        }

        private void ConductorWeight_Load(object sender, EventArgs e)
        {

        }

        private void conductorbutton_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double wc = 0;
            double l = 0;
            double t = 0;
            double.TryParse(WTB.Text,out wc);
            double.TryParse(LTB.Text, out l);
            double.TryParse(TTB.Text, out t);
            double result = ((wc*l*l)/(8*t));
            OP.Text = result.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
