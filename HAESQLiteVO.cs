using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAESticker
{
    public class HAESQLiteVO
    {
        private Dictionary<string, object> haeSQLiteVO = null;

        public HAESQLiteVO()
        {
            haeSQLiteVO = new Dictionary<string, object>();
        }

        public object get(string key)
        {
            return haeSQLiteVO[key];
        }

        public void set(string key, object val)
        {
            if (haeSQLiteVO.ContainsKey(key))
            {
                haeSQLiteVO[key] = val;
            }
            else
            {
                haeSQLiteVO.Add(key, val);
            }
        }

        public void remove(string key, object val)
        {
            haeSQLiteVO.Remove(key);
        }

        public int size()
        {
            return haeSQLiteVO.Count;
        }

        public string getKeys(int idx)
        {
            return haeSQLiteVO.Keys.ToList()[idx];
        }
    }
}
