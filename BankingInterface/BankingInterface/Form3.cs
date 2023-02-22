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
    public partial class Form3 : Form
    {
        string name, cust_id;
        public Form3(string name, string custid)
        {
            InitializeComponent();
            this.name = name;
            this.cust_id = custid;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2(name,cust_id);
            f.Show();
        }
    }
}
