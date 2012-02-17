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
    public partial class Bonds : Form
    {
        private int account_id;
        private DBAccess db;

        public Bonds(int account_id1)
        {
            account_id = account_id1;
            InitializeComponent();
            db = new DBAccess();
        }



        private void insertbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.insert_bond(account_id, Bondname.Text, bondtype.Text, decimal.Parse(riskvalue.Text.ToString()), decimal.Parse(principle.Text.ToString()), decimal.Parse(interestrate.Text.ToString()), startdate.Value, enddate.Value);
                this.Close();
            }
            catch
            {
                label8.Visible = true;
            }
        }
    }
}
