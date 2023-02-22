using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingInterface
{
    public partial class Form2 : Form
    {
        public Form2(string name,string custid)
        {
            InitializeComponent();
            namelabel.Text = name;
            custidlabel.Text = custid;

        }

        private void changepin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(namelabel.Text,custidlabel.Text);
            f.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4(namelabel.Text,custidlabel.Text);
            f.Show();
        }
    }
}
