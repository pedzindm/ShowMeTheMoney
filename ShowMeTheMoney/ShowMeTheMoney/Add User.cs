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
    public partial class Add_User : Form
    {
        private DBAccess db;
        public Add_User()
        {
            InitializeComponent();
            db = new DBAccess();
            DataTable dt = db.select_allquestions();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
        }

        private void edituserbutton_Click(object sender, EventArgs e)
        {
            if (passwordtb.Text.Length < 5 || passwordtb.Text.Length > 15)
            {
                label3.Text = "Passwords must be between 5 and 15 characters";
                label3.Visible = true;
            }
            else if (phonetb.Text.Length != 10 || phonetb.Text.Contains('-') )
            {
                label3.Text = "Phone Number must be 10 digits long and no - ";
                label3.Visible = true;

            }
            else if (!emailtb.Text.Contains('@') || !emailtb.Text.Contains('.'))
            {
                label3.Text = "invaild email ";
                label3.Visible = true;

            }
            else if (lnametb.Text.Length == 0 || fnametb.Text.Length == 0)
            {
                label3.Text = "Inval First Name or Last Name";
                label3.Visible = true;

            }
            else
            {
                try
                {
                    db.insert_user(usernametb.Text, passwordtb.Text, phonetb.Text, emailtb.Text, lnametb.Text, fnametb.Text);
                    db.insert_answers(textBox1.Text, comboBox1.SelectedIndex, db.select_userid(usernametb.Text, passwordtb.Text));
                    this.Close();
                }
                catch
                {

                    label3.Text = "Please pick a new username";
                    label3.Visible = true;
                }


            }
            
        }

    }
}
