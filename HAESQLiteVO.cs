using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAESticker
{
    class HAESQLiteVO
    {
        private Dictionary<string, object> haeSQLiteVO = null;

        public HAESQLiteVO()
        {
            haeSQLiteVO = new Dictionary<string, object>();
        }

        public void add(string key, object val)
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

        public object get(string key)
        {
            return haeSQLiteVO[key];
        }
    }
}
