using System;
using System.Collections.Generic;
using System.Text;

namespace IEAjax
{
    class Utils
    {
        public static string ListtoString<T>(List<T> list)
        {
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str += list[i].ToString() + " - "+i+"\r\n";
            }

            return str;
        }
    }
}
