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
    public partial class buystock : Form
    {
        private DBAccess db;
        private int acct;
        public ObservableCollection<Quote> Quotes { get; set; }
        public buystock(int account)
        {
            InitializeComponent();
            acct = account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quotes = new ObservableCollection<Quote>();
            db = new DBAccess();
            //Some example tickers
            Quotes.Add(new Quote(textBox1.Text.ToUpper()));
            //get the data
            YahooStockEngine.Fetch(Quotes);
            try
            {
                db.insert_stock(textBox1.Text.ToUpper(), Quotes[0].LastUpdate, Quotes[0].DividendShare, Quotes[0].Name, Quotes[0].StockExchange, Quotes[0].ChangeInPercent,
                    Quotes[0].LastTradePrice, Quotes[0].Volume, Quotes[0].YearlyHigh, Quotes[0].YearlyLow, Quotes[0].DailyHigh, Quotes[0].DailyLow, Quotes[0].PeRatio);

                db.insert_stockhistory(DateTime.Now, "BUY", decimal.Parse(textBox2.Text), acct, db.select_stock(textBox1.Text.ToUpper()));

            }
            catch
            {

                Console.WriteLine("error");

            }
            
            
            this.Close();


        }

    }
}
