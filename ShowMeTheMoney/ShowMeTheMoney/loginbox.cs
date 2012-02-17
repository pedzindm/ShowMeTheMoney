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
    public partial class loginbox : Form
    {
        private DBAccess db;
        public loginbox()
        {
            InitializeComponent();
            db = new DBAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.verify_user(username.Text, password.Text))
            {
                accounts fm = new accounts(username.Text, password.Text);

                fm.Show();
                this.Hide();
                fm.AddOwnedForm(this);
            }
            else
            {
                label3.Visible = true;


            }
            

            
        }

        private void forgotpwd_Click(object sender, EventArgs e)
        {
            forgotpassword fm = new forgotpassword();

            fm.Show();
            this.Hide();
            fm.AddOwnedForm(this); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Add_User fm = new Add_User();

            fm.Show();

            
        }




    }
}
