using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowMeTheMoney
{
    public partial class Cash : Form
    {
        private DBAccess db;
        private int accountid;
        public Cash(int acctid)
        {
            InitializeComponent();
            accountid = acctid;
            db = new DBAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                db.insert_cash(accountid, decimal.Parse(textBox1.Text));
                this.Close();
            //}
            //catch
            //{


            //}
        }
    }
}
