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
    public partial class forgotpassword : Form
    {
        private DBAccess db;
        private int userid;
        private DataTable dt;
        public forgotpassword()
        {
            InitializeComponent();
           
            db = new DBAccess();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                DataTable dt2 = db.select_questions(username.Text);
                foreach (DataRow dr in dt2.Rows)
                {
                    if (dr[0].ToString() == comboBox1.SelectedItem.ToString() && dr[1].ToString() == textBox1.ToString())
                    {
                        label1.Text = "Password is " + dr[2].ToString();
                        label1.Visible = true;

                    }
                    else
                    {
                        label1.Text = "Something is wrong";
                        label1.Visible = true;
                    }

                }
                this.Refresh();

                
            
        }

        private void forgotpassword_Load(object sender, EventArgs e)
        {
            dt = db.select_allquestions();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
        }


    }
}
