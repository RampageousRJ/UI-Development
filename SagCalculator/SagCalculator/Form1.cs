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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conductorbutton_Click(object sender, EventArgs e)
        {
            ConductorWeight frm = new ConductorWeight();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void windbutton_Click(object sender, EventArgs e)
        {
            Wind frm = new Wind();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void icebutton_Click(object sender, EventArgs e)
        {
            Ice frm = new Ice();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
