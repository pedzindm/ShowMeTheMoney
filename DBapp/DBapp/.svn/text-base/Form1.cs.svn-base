using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace DBapp
{
    public partial class Form1 : Form
    {
        string folderpath;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderpath = fbd.SelectedPath;
                textBox1.Text = folderpath;

            }

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            ExcelH excelhelper = new ExcelH();
            DBAccess db = new DBAccess();

            ArrayList clients = excelhelper.getclients(excelhelper,folderpath);

            foreach (Customer Cust in clients)
            {
                string maininfo = Cust.CustomerID + "','" + Cust.CustomerName;
                db.InsertData_into_maininfo(maininfo);
                for(int cat=0; cat<Cust.category.Count();cat++){
                    string custallo = Cust.CustomerID + "','" +Cust.category[cat] + "','"+Cust.percentage[cat];
                    db.InsertData_into_custallo(custallo);
                }
               
            }
            dataGridView1.DataSource = db.SelectData_from_maininfo();
            dataGridView2.DataSource = db.SelectData_from_custallo();

        }
    }
}
