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
        private SQLiteCommand sqlCmd;
        
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
            string dbPath = System.Windows.Forms.Application.StartupPath + "\\DB\\sticker.db";
            conn = new SQLiteConnection(@"Data Source=" + dbPath);
        }

        public DataTable select(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sqlCmd = conn.CreateCommand();
                sqlCmd.CommandText = sql;
                SQLiteDataReader reader = sqlCmd.ExecuteReader();
                dt.Load(reader);
            }
            catch(Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable select(string sql, HAESQLiteVO vo)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sqlCmd = conn.CreateCommand();
                sqlCmd.CommandText = sql;
                string columnName = string.Empty;
                for(int idx = 0; idx < vo.size(); idx++)
                {
                    columnName = vo.getKeys(idx);
                    sqlCmd.Parameters.AddWithValue("@" + columnName, vo.get(columnName));
                }
                SQLiteDataReader reader = sqlCmd.ExecuteReader();
                dt.Load(reader);
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public int executeQuery(string sql)
        {
            int exeCnt = 0;
            try
            {
                conn.Open();
                sqlCmd = conn.CreateCommand();
                sqlCmd.CommandText = sql;
                exeCnt = sqlCmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }            
            return exeCnt;
        }

        public int executeQuery(string sql, HAESQLiteVO vo)
        {
            int exeCnt = 0;
            try
            {
                conn.Open();
                sqlCmd = conn.CreateCommand();
                sqlCmd.CommandText = sql;
                string columnName = string.Empty;
                for (int idx = 0; idx < vo.size(); idx++)
                {
                    columnName = vo.getKeys(idx);
                    sqlCmd.Parameters.AddWithValue("@" + columnName, vo.get(columnName));
                }
                exeCnt = sqlCmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return exeCnt;
        }

    }
}
