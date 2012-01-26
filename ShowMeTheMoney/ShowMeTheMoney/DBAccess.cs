using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using Npgsql;
using System.Data;
using NpgsqlTypes;
using System.Windows.Forms;

namespace ShowMeTheMoney
{
     class DBAccess
    {
        private string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=Test;Database=showmethemoney;";
        private NpgsqlConnection conn;

        private void OpenConnection()
        { 
            conn= new NpgsqlConnection(connstring);
            
            conn.Open();
                 MessageBox.Show(conn.State.ToString());
            
        }
        private void CloseConnection()
        {
            conn.Close();
        }

        public void InsertData_into_stock()
        {
            this.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandText="insert_stock";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new NpgsqlParameter("ticker", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("_date", NpgsqlDbType.Date));
            command.Parameters.Add(new NpgsqlParameter("dividend_rate", NpgsqlDbType.Numeric));
            command.Parameters.Add(new NpgsqlParameter("year_low", NpgsqlDbType.Numeric));
            command.Parameters.Add(new NpgsqlParameter("year_high", NpgsqlDbType.Numeric));
            command.Parameters.Add(new NpgsqlParameter("closing_price", NpgsqlDbType.Numeric));
            command.Parameters.Add(new NpgsqlParameter("opening_price", NpgsqlDbType.Numeric));
            //command.Parameters["ticker"].NpgsqlDbType = NpgsqlDbType.Varchar;
            command.Parameters[0].Value = "GOOG";
            //command.Parameters["_date"].NpgsqlDbType = NpgsqlDbType.Date;
            command.Parameters[1].Value = new DateTime(2012, 1, 25);
           // command.Parameters["dividend_rate"].NpgsqlDbType = NpgsqlDbType.Numeric;
            command.Parameters[2].Value = new Decimal(.08);
            //command.Parameters["year_low"].NpgsqlDbType = NpgsqlDbType.Numeric;
            command.Parameters[3].Value = new Decimal(95.23);
            //command.Parameters["year_high"].NpgsqlDbType = NpgsqlDbType.Numeric;
            command.Parameters[4].Value = new Decimal(95.23);
           // command.Parameters["closing_price"].NpgsqlDbType = NpgsqlDbType.Numeric;
            command.Parameters[5].Value = new Decimal(95.23);
           // command.Parameters["opening_price"].NpgsqlDbType = NpgsqlDbType.Numeric;
            command.Parameters[6].Value = new Decimal(95.23);
            
            //command.Parameters.AddWithValue("_date", new DateTime(2012,1,25).Date); 
            //command.Parameters.AddWithValue("dividend_rate", .08);
            //command.Parameters.AddWithValue("year_low", 95.23);
            //command.Parameters.AddWithValue("year_high", 95.23);
            //command.Parameters.AddWithValue("closing_price", 95.23);
            //command.Parameters.AddWithValue("opening_price", 95.23);
           command.ExecuteScalar();
         
            this.CloseConnection();
        }
      
    }
}
