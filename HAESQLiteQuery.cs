using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HAESticker
{
    public class HAESQLiteQuery
    {
        HAESQLiteHelper haeSQLiteHelper = new HAESQLiteHelper();
        XmlDocument doc = new XmlDocument();

        public HAESQLiteQuery()
        {   
            doc.Load("HAESQLQuery.xml");
        }

        public DataTable getStickerInfo(HAESQLiteVO vo)
        {
            string sql = string.Empty;
            sql = doc.SelectSingleNode("//*[@id='getStickerInfo']").InnerText;
            DataTable dt = new DataTable();
            dt = haeSQLiteHelper.select(sql);
            return dt;
        }

        public DataTable getStickerInfoByFormId(HAESQLiteVO vo)
        {
            string sql = string.Empty;
            sql = doc.SelectSingleNode("//*[@id='getStickerInfoByFormId']").InnerText;
            DataTable dt = new DataTable();
            dt = haeSQLiteHelper.select(sql, vo);
            return dt;
        }

        public int insertStickerInfo(HAESQLiteVO vo)
        {
            int cnt = 0;
            string sql = string.Empty;
            sql = doc.SelectSingleNode("//*[@id='insertStickerInfo']").InnerText;
            cnt = haeSQLiteHelper.executeQuery(sql, vo);
            return cnt;
        }

        public int updateStickerInfo(HAESQLiteVO vo)
        {
            int cnt = 0;
            string sql = string.Empty;
            sql = doc.SelectSingleNode("//*[@id='updateStickerInfo']").InnerText;
            cnt = haeSQLiteHelper.executeQuery(sql, vo);
            return cnt;
        }
    }
}
