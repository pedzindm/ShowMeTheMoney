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
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Form1 fm = new Form1(user_id, int.Parse(comboBox1.SelectedItem.ToString().Split(':')[1]));

                fm.Show();
                this.Hide();
                fm.AddOwnedForm(this);
           
       }
    }
}
