using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankingInterface
{
    public partial class Form4 : Form
    {
        string name,cust_id;
        public Form4(string name, string custid){
            InitializeComponent();
            this.name = name;
            this.cust_id = custid;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Money sent successfully!", "Success", MessageBoxButtons.OK);
            if(dr == DialogResult.OK){
                this.Hide();
                Form2 f = new Form2(name,cust_id);
                f.Show();
            }
        }
    }
}
