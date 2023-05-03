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
    public partial class Ice : Form
    {
        public Ice()
        {
            InitializeComponent();
        }

        private void Ice_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double wc = 0;
            double D = 0;
            double l = 0;
            double t = 0;
            double rt = 0;
            double density = 0;
            double.TryParse(WTB.Text, out wc);
            double.TryParse(DTB.Text, out D);
            double.TryParse(LTB.Text, out l);
            double.TryParse(TTB.Text, out t);
            double.TryParse(densityTB.Text, out density);
            double.TryParse(thickTB.Text, out rt);
            double wi = Math.PI*rt*(D+rt)*density;
            double result = (((wi+wc) * l * l) / (8 * t));
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
