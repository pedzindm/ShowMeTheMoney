using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using Npgsql;
using System.Data;

namespace DBapp
{
     class DBAccess
    {
        private string connstring = "Server=localhost;Port=5432;User Id=Dale;Password=Test;Database='innsbruck';";
        private NpgsqlConnection conn;

        private void OpenConnection()
        { 
            conn= new NpgsqlConnection(connstring);
            conn.Open();
        }
        private void CloseConnection()
        {
            conn.Close();
        }

        public void InsertData_into_custallo(String str)
        {
            this.OpenConnection();
            String sql = "INSERT INTO custallocation VALUES('"+str+"')";
            NpgsqlCommand exc = new NpgsqlCommand(sql, conn);
            exc.ExecuteNonQuery();
            this.CloseConnection();
        }
        public void InsertData_into_maininfo(String str)
        {
            this.OpenConnection();
            String sql = "INSERT INTO maininfo VALUES('" + str + "')";
            NpgsqlCommand exc = new NpgsqlCommand(sql, conn);
            exc.ExecuteNonQuery();
            this.CloseConnection();
        }

        public DataTable SelectData_from_custallo()
        {
           
            this.OpenConnection();
            String sql = "SELECT * from custallocation";
            NpgsqlCommand exc = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = exc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustID");
             dt.Columns.Add("Label");
             dt.Columns.Add("Percentage");
            while(dr.Read())
            {
                dt.Rows.Add(dr[0],dr[1],dr[2]);
            }
            this.CloseConnection();
            return dt;
        }
        public DataTable SelectData_from_maininfo()
        {

            this.OpenConnection();
            String sql = "SELECT * from maininfo";
            NpgsqlCommand exc = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = exc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustID");
            dt.Columns.Add("NAME");
            while (dr.Read())
            {
                dt.Rows.Add(dr[0], dr[1]);
            }
            this.CloseConnection();
            return dt;
        }
    }
}
