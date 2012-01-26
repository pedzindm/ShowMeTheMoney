/*
    Jarloo
    http://jarloo.com
 
    This work is licensed under a Creative Commons Attribution-ShareAlike 3.0 Unported License  
    http://creativecommons.org/licenses/by-sa/3.0/     

*/
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;
using Jarloo.CardStock.Helpers;
using Jarloo.CardStock.Models;

namespace Jarloo.CardStock.ViewModels
{
    public class CardDeckViewModel : DependencyObject
    {
        private readonly DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Background);

        public ObservableCollection<Quote> Quotes { get; set; }

        public CardDeckViewModel()
        {
            Quotes = new ObservableCollection<Quote>();

            //Some example tickers
            Quotes.Add(new Quote("LMT"));
            Quotes.Add(new Quote("GOOG"));
            Quotes.Add(new Quote("INTC"));
            Quotes.Add(new Quote("IBM"));
            Quotes.Add(new Quote("RVBD"));
            Quotes.Add(new Quote("AMZN"));
            Quotes.Add(new Quote("BIDU"));
            Quotes.Add(new Quote("SINA"));
            Quotes.Add(new Quote("THI"));
            Quotes.Add(new Quote("NVDA"));
            Quotes.Add(new Quote("AMD"));
            Quotes.Add(new Quote("DELL"));
            Quotes.Add(new Quote("WMT"));
            Quotes.Add(new Quote("GLD"));
            Quotes.Add(new Quote("SLV"));
            Quotes.Add(new Quote("V"));
            Quotes.Add(new Quote("V"));
            Quotes.Add(new Quote("MCD"));

            //get the data
            YahooStockEngine.Fetch(Quotes);

            //poll every 25 seconds
            timer.Interval = new TimeSpan(0, 0, 25); 
            timer.Tick += (o, e) => YahooStockEngine.Fetch(Quotes);
                              
            timer.Start();
        }
    }
}