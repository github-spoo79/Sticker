using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace HAESticker
{
    class HAESQLiteHelper
    {
        private SQLiteConnection conn;
        private SQLiteCommand sqlcmd;
        
        private string sqliteFileName = string.Empty;

        public HAESQLiteHelper()
        {
            setConnection();
        }

        public HAESQLiteHelper(string sqliteFileName)
        {
            this.sqliteFileName = sqliteFileName;

            if (!File.Exists(sqliteFileName))
            {
                SQLiteConnection.CreateFile(sqliteFileName);
                //Sticker 프로그램 Table 초기화
            }

            setConnection();
        }

        public void setConnection()
        {
            //conn = new SQLiteConnection("Data Source=" + System.Windows.Forms.Application.StartupPath + "\\DB\\sticker.db");
            //D:\workspaces\projects\Sticker\bin\Debug\DB
            string dbPath = System.Windows.Forms.Application.StartupPath + "\\DB\\sticker.db";

            //conn = new SQLiteConnection(@"Data Source=D:\\workspaces\\projects\\Sticker\\bin\\Debug\\DB\\sticker.db");
            conn = new SQLiteConnection(@"Data Source=" + dbPath);
        }

        public DataTable selectData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sqlcmd = conn.CreateCommand();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dt;
        }

        public DataTable selectData(string sql, DataTable dtParam)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sqlcmd = conn.CreateCommand();
                for (int idx = 0; idx < dtParam.Columns.Count; idx++)
                {
                    sqlcmd.Parameters.AddWithValue(dtParam.Columns[idx].ColumnName, dtParam.Rows[0][dtParam.Columns[idx].ColumnName]);
                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
            }
            catch
            {
            }
            return dt;
        }

        public int executeData(string sql)
        {
            int exeCnt = 0;
            return exeCnt;
        }

        public int executeData(string sql, DataTable dtParam)
        {
            int exeCnt = 0;
            return exeCnt;
        }

    }
}
