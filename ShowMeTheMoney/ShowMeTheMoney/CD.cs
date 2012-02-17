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
    public partial class CD : Form
    {
        private int account_id;
        private DBAccess db;
        public CD(int account_id1)
        {
            account_id = account_id1;
            InitializeComponent();
            db = new DBAccess();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                db.insert_cd(account_id, Bankname.Text, decimal.Parse(principle.Text.ToString()), decimal.Parse(interestrate.Text.ToString()), startdate.Value, enddate.Value);
                this.Close();
            }
            catch 
            {
                label6.Visible = true;
            }
            
        }


    }
}
