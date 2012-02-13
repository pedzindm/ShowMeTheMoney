using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;


namespace ShowMeTheMoney
{
    public partial class Form1 : Form
    {
        private int user_id, account_id;
        private DBAccess db;
        public ObservableCollection<Quote> Quotes { get; set; }
        DataTable lookuphistory = new DataTable();
        
        public Form1(int user_id1, int account_id1)
        {
            db = new DBAccess();
            user_id = user_id1;
            account_id = account_id1;
            this.contructors();
        }
        public void contructors()
        {
            InitializeComponent();
            lookuphistory.Columns.Add("Ticker");
            lookuphistory.Columns.Add("Last Updated");
            lookuphistory.Columns.Add("Dividend Share");
            lookuphistory.Columns.Add("Stock Name");
            lookuphistory.Columns.Add("Change in Percent");
            lookuphistory.Columns.Add("Current Price");
            lookuphistory.Columns.Add("Daily High");
            lookuphistory.Columns.Add("Daily Low");
        }

#region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Dock = DockStyle.Fill;
            panel1.Anchor = AnchorStyles.Left;
            panel2.Dock = DockStyle.Fill;
            panel2.Anchor = AnchorStyles.Left;
            panel1.Visible = true;
            panel2.Visible = true;
            panel1.Show();
            panel2.Hide();
            TopPerformers.DataSource = db.getTopPerformers();
            stocksview.DataSource = db.getallStocks(account_id);
            cdview.DataSource = db.select_allcd(account_id);
            bondsview.DataSource = db.select_allbonds(account_id);
            currentcdview.DataSource = db.select_allcd(account_id);
            currentbondview.DataSource = db.select_allbonds(account_id);
            stockhistoryview.DataSource = db.select_allstockhistory(account_id);
            historybondsview.DataSource = db.select_allbondshistory(account_id);
            historyCDview.DataSource = db.select_allcdhistory(account_id);
            cash.Text = db.select_cash(account_id);
            netvalue.Text = db.getnetvalue(account_id);
        }
#endregion

#region Home
   private void DashboardMitem_Click(object sender, EventArgs e)
       {
           panel1.Show();
           panel2.Hide();



       }
       private void StockMitem_Click(object sender, EventArgs e)
       {
           panel1.Hide();
           panel2.Show();
       }

       private void updateToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
       }
#endregion

       private void tickerlookupbutton_Click(object sender, EventArgs e)
       {
           Quotes = new ObservableCollection<Quote>();

           //Some example tickers
           Quotes.Add(new Quote(lookuptextbox.Text.ToUpper()));
           //get the data
           YahooStockEngine.Fetch(Quotes);

           lookuphistory.Rows.Add(lookuptextbox.Text, Quotes[0].LastUpdate, Quotes[0].DividendShare, Quotes[0].Name, Quotes[0].ChangeInPercent, Quotes[0].LastTradePrice, Quotes[0].DailyHigh, Quotes[0].DailyLow);
           labeldailyhigh.Text = Quotes[0].DailyHigh.ToString();
           labeldailylow.Text = Quotes[0].DailyLow.ToString();
           labelyearlyhigh.Text = Quotes[0].YearlyHigh.ToString();
           labeldividendrate.Text = Quotes[0].DividendShare.ToString();
           labelPEratio.Text = Quotes[0].PeRatio.ToString();
           labellastupdate.Text = Quotes[0].LastUpdate.ToString();
           labelcurrentprice.Text = Quotes[0].LastTradePrice.ToString() + " ( " + Quotes[0].ChangeInPercent.ToString() + " )";
           labeltickersymbol.Text = Quotes[0].Name.ToString() + " ( " + Quotes[0].StockExchange.ToString() + " : " + lookuptextbox.Text.ToUpper() + " )";

           lookupview.DataSource = lookuphistory;

           panel3.Refresh();
       
       
       }

       private void addcd_Click(object sender, EventArgs e)
       {
           investment im = new investment(account_id);
           im.Show();
       }

       private void addbond_Click(object sender, EventArgs e)
       {

       }

       private void changeAccount_Click(object sender, EventArgs e)
       {
           DataTable dt2 = db.getusernameandpassword(user_id);
           foreach (DataRow dr in dt2.Rows)
           {
               accounts fm = new accounts(dr[0].ToString(),dr[1].ToString());
               fm.Show();
               this.Hide();
               fm.AddOwnedForm(this); 

           }
           


           
       }

       private void sellstock_Click(object sender, EventArgs e)
       {

       }

       private void buystock_Click(object sender, EventArgs e)
       {

       }

       private void investhistory_Click(object sender, EventArgs e)
       {
           historystock.Hide();
           historyinvestment.Show();
       }

       private void stockhistory_Click(object sender, EventArgs e)
       {
           historystock.Show();
           historyinvestment.Hide();
       }
















    }
}
