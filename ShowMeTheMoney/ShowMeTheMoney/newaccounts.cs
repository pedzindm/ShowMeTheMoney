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
    public partial class newaccounts : Form
    {
       private DBAccess db; 
        private int user_id1;

        public newaccounts(int user_id)
        {
            InitializeComponent();
            db = new DBAccess();
            user_id1 = user_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            db.insert_account(textBox1.Text.ToString());
            int acc_id=int.Parse(db.select_accountid());
            db.insert_maintains(acc_id, user_id1);
            
            this.Close();
        }
    }
}
