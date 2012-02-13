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
    public partial class investment : Form
    {
        private int account_id;
        private DBAccess db;
        public investment(int account_id1)
        {
            account_id = account_id1;
            InitializeComponent();
            db = new DBAccess();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            
        }


    }
}
