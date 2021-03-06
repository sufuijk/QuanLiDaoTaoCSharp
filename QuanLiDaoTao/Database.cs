﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace QuanLiDaoTao
{
    class Database
    {
        private static Database instance;
        public SqlConnection connect;
        public SqlDataAdapter adt;
        public SqlCommandBuilder cmd;

        public DataTable table;
      
        private Database(){
            string stringConnect = @"Data Source = SUFUIJK\SQLEXPRESS; Initial Catalog = QUANLIDKDAOTAO; Integrated Security = True";
            this.connect = new SqlConnection();
            this.connect.ConnectionString = stringConnect;
        }

        public static Database Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public DataTable LoadData(string sql)
        {
            this.connect.Open();
            table = new DataTable();
            this.adt = new SqlDataAdapter(sql, this.connect);
            this.adt.Fill(table);
            this.connect.Close();
            return table;
        }

        public void Update(DataTable table)
        {
            this.cmd = new SqlCommandBuilder(this.adt);
            this.adt.Update(table);

        }
        
        public int CheckUser(string sql)
        {
            this.connect.Open();
            table = new DataTable();
            adt = new SqlDataAdapter(sql, this.connect);
            adt.Fill(table);
            this.connect.Close();

            return (table.Rows.Count > 0) ? 1 : 0; 
        }

        public int CountAttribute(string sql)
        {
            //Query example = SELECT COUNT(*) AS NUMBER FROM TABLE
            this.connect.Open();
            table = new DataTable();
            adt = new SqlDataAdapter(sql, this.connect);
            adt.Fill(table);
            int Count = int.Parse(table.Rows[0]["NUMBER"].ToString());
            this.connect.Close();
            return Count;
        }

        public int SumAttribute(string sql)
        {
            //Query example = SELECT SUM(col) AS TONG FROM TABLE
            this.connect.Open();
            table = new DataTable();
            adt = new SqlDataAdapter(sql, this.connect);
            adt.Fill(table);
            int sum = int.Parse(table.Rows[0]["TONG"].ToString());
            this.connect.Close();
            return sum;
        }

    }
}
