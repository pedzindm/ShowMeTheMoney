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
    public partial class accounts : Form
    {
        private string username, password;
        private int user_id, account_id;
        private DBAccess db;

        public accounts(string username1, string password1)
        {
            db = new DBAccess();
            username = username1;
            password = password1;
            InitializeComponent();
           DataTable dt=db.select_allaccountid(username, password);
           foreach (DataRow dr in dt.Rows)
           {
               comboBox1.Items.Add(dr[1].ToString() + ":" + dr[0].ToString());

           }
           user_id = db.select_userid(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_id = db.select_userid(username, password);
            try
            {
                Form1 fm = new Form1(user_id, int.Parse(comboBox1.SelectedItem.ToString().Split(':')[1].Trim()));

                fm.Show();
                this.Hide();
                fm.AddOwnedForm(this);
            }
            catch
            {


            }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            newaccounts an = new newaccounts(user_id);
            an.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = db.select_allaccountid(username, password);
            comboBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[1].ToString() + ":" + dr[0].ToString());

            }
        }
    }
}
