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

        #region Stock Charts
        public DataTable getTopPerformers()
        {
            
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_topperformingstocks";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("s_date", NpgsqlDbType.Date));
            da.SelectCommand.Parameters[0].Value = DateTime.Today.Date;
 
            da.Fill(dt);
            
            conn.Close();
            return dt;
        }

        #endregion

        #region Dashboard
        public DataTable getallStocks(int userId )
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allstocks";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("User_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = userId;

            da.Fill(dt);

            conn.Close();
            return dt;
        }

        public DataTable select_allbonds(int account_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allbonds";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = account_id;

            da.Fill(dt);

            conn.Close();
            return dt;

        }
        public DataTable select_allcd(int account_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allcd";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = account_id;

            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public string select_cash(int account_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_cash";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters[0].Value = account_id;


            string output = cmd.ExecuteScalar().ToString();
            conn.Close();
            return output;

        }

        public DataTable select_allcash(int account_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allcash";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));

            da.SelectCommand.Parameters[0].Value = account_id;
           

            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public string select_accountid()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_accountid";
            cmd.CommandType = CommandType.StoredProcedure;


            string output = cmd.ExecuteScalar().ToString();
            conn.Close();
            return output;

        }

        public string getnetvalue(int account_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            bool dt = new bool();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getnetvalue";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters[0].Value = account_id;


            string output = cmd.ExecuteScalar().ToString();
            conn.Close();
            return output;
        }

        public void insert_stock(string ticker, DateTime s_date, decimal d_rate, String s_name, String s_exchange, decimal change_rate, decimal cur_price, decimal volume, decimal yr_high, decimal yr_low, decimal day_high, decimal day_low, decimal pe_ratio)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_stock";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("ticker", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("s_date", NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("d_rate", NpgsqlDbType.Numeric));
            cmd.Parameters.Add(new NpgsqlParameter("s_name", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("s_exchange", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("change_rate", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("cur_price", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("volume", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("yr_high", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("yr_low", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("day_high", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("day_low", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("pe_ratio", NpgsqlDbType.Double));
            cmd.Parameters[0].Value = ticker;
            cmd.Parameters[1].Value = s_date;
            cmd.Parameters[2].Value = d_rate;
            cmd.Parameters[3].Value = s_name;
            cmd.Parameters[4].Value = s_exchange;
            cmd.Parameters[5].Value = change_rate;
            cmd.Parameters[6].Value = cur_price;
            cmd.Parameters[7].Value = volume;
            cmd.Parameters[8].Value = yr_high;
            cmd.Parameters[9].Value = yr_low;
            cmd.Parameters[10].Value = day_high;
            cmd.Parameters[11].Value = day_low;
            cmd.Parameters[12].Value = pe_ratio;


           cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_stockhistory(DateTime sh_date, string sh_type, decimal quantity, int account_id, int stock_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_stockhistory";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("sh_date", NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("sh_type", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("quantity", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("stock_id", NpgsqlDbType.Integer));

            cmd.Parameters[0].Value = sh_date;
            cmd.Parameters[1].Value = sh_type;
            cmd.Parameters[2].Value = quantity;
            cmd.Parameters[3].Value = account_id;
            cmd.Parameters[4].Value = stock_id;


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_cd(int account_id, string bank_name, decimal principle, decimal interest_rate, DateTime start_date, DateTime end_date)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_cd";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("bank_name", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("principle", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("interest_rate", NpgsqlDbType.Numeric));
            cmd.Parameters.Add(new NpgsqlParameter("start_date", NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("end_date", NpgsqlDbType.Date));

            cmd.Parameters[0].Value = account_id;
            cmd.Parameters[1].Value = bank_name;
            cmd.Parameters[2].Value = principle;
            cmd.Parameters[3].Value = interest_rate;
            cmd.Parameters[4].Value = start_date;
            cmd.Parameters[5].Value = end_date;

            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void insert_bond(int account_id, string name,string b_type, decimal r_value, decimal principle, decimal interest_rate, DateTime start_date, DateTime end_date)
        {
        
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_bond";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("name", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("b_type", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("r_value", NpgsqlDbType.Numeric));
            cmd.Parameters.Add(new NpgsqlParameter("principle", NpgsqlDbType.Double));
            cmd.Parameters.Add(new NpgsqlParameter("interest_rate", NpgsqlDbType.Numeric));
            cmd.Parameters.Add(new NpgsqlParameter("start_date", NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("end_date", NpgsqlDbType.Date));

            cmd.Parameters[0].Value = account_id;
            cmd.Parameters[1].Value = name;
            cmd.Parameters[2].Value = b_type;
            cmd.Parameters[3].Value = r_value;
            cmd.Parameters[4].Value = principle;
            cmd.Parameters[5].Value = interest_rate;
            cmd.Parameters[6].Value = start_date;
            cmd.Parameters[7].Value = end_date;

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void update_user( int user_id,string username, string pwd, string phone, string email, string l_name, string f_name)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("username", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("pwd", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("email", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("l_name", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("f_name", NpgsqlDbType.Varchar));

            cmd.Parameters[0].Value = user_id;
            cmd.Parameters[1].Value = username;
            cmd.Parameters[2].Value = pwd;
            cmd.Parameters[3].Value = phone;
            cmd.Parameters[4].Value = email;
            cmd.Parameters[5].Value = l_name;
            cmd.Parameters[6].Value = f_name;


            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void delete_user(int user_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));
  
            cmd.Parameters[0].Value = user_id;


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_user( string username, string pwd, string phone, string email, string l_name, string f_name)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("username", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("pwd", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("email", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("l_name", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("f_name", NpgsqlDbType.Varchar));

            cmd.Parameters[0].Value = username;
            cmd.Parameters[1].Value = pwd;
            cmd.Parameters[2].Value = phone;
            cmd.Parameters[3].Value = email;
            cmd.Parameters[4].Value = l_name;
            cmd.Parameters[5].Value = f_name;


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_account(string accountName)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_account";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_name", NpgsqlDbType.Varchar));


            cmd.Parameters[0].Value = accountName;



            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_cash(int account_id, decimal amount)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_cash";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("amount", NpgsqlDbType.Double));

            cmd.Parameters[0].Value = account_id;
            cmd.Parameters[1].Value = amount;


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void insert_maintains(int account_id, int user_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_maintains";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));

            cmd.Parameters[0].Value = account_id;
            cmd.Parameters[1].Value = user_id;



            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void insert_answers(string answers, int question_id, int user_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_answers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("answers", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("question_id", NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));

            cmd.Parameters[0].Value = answers;
            cmd.Parameters[1].Value = question_id;
            cmd.Parameters[2].Value = user_id;



            cmd.ExecuteNonQuery();
            conn.Close();

        }

        #endregion

        #region login 
        public bool verify_user(string username, string pwd)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            bool dt = new bool();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection=conn;
            cmd.CommandText = "verify_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("u_username", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("u_password", NpgsqlDbType.Varchar));
            cmd.Parameters[0].Value = username;
            cmd.Parameters[1].Value = pwd;

            string output=cmd.ExecuteScalar().ToString();
            conn.Close();
            if (output == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        public DataTable getusernameandpassword( int user_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "getusernameandpassword";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = user_id;

            da.Fill(dt);

            conn.Close();
            return dt;

        }


        #endregion

        #region accounts
        public DataTable select_allaccountid(string username, string pwd)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allaccountid";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("u_username", NpgsqlDbType.Varchar));
            da.SelectCommand.Parameters.Add(new NpgsqlParameter("u_password", NpgsqlDbType.Varchar));
            da.SelectCommand.Parameters[0].Value = username;
            da.SelectCommand.Parameters[1].Value = pwd;

            da.Fill(dt);

            conn.Close();
            return dt;

        }
        #endregion

        public DataTable select_allstockhistory(int account_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allstockhistory";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = account_id;


            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public int select_stock(string ticker)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_stock";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("ticker", NpgsqlDbType.Varchar));
 
            cmd.Parameters[0].Value = ticker;

            int output = int.Parse(cmd.ExecuteScalar().ToString());

            conn.Close();
            return output;

        }

        public DataTable select_allbondshistory(int account_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allbondshistory";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = account_id;

            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public DataTable select_allcdhistory(int account_id)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allcdhistory";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("account_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = account_id;

            da.Fill(dt);

            conn.Close();
            return dt;

        }


        public int select_userid(string username, string pwd)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_userid";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new NpgsqlParameter("username", NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("user_password", NpgsqlDbType.Varchar));
            cmd.Parameters[0].Value = username;
            cmd.Parameters[1].Value = pwd;

            int output = int.Parse(cmd.ExecuteScalar().ToString());

            conn.Close();
            return output;

        }

        public DataTable select_questions(string username)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_questions";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("username", NpgsqlDbType.Varchar));
            da.SelectCommand.Parameters[0].Value = username;

            da.Fill(dt);

            conn.Close();
            return dt;

        }
        public DataTable select_user(int userid)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_user";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Integer));
            da.SelectCommand.Parameters[0].Value = userid;

            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public DataTable select_allquestions()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = new NpgsqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = "select_allquestions";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.Fill(dt);

            conn.Close();
            return dt;



        }


    }
}
