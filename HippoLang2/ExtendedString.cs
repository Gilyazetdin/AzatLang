using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExtensions
{
    public static class ExtendedString
    {
        public static List<string> HippoSplit(this string buf)
        {
            List<string> arr = new List<string>();
            int previous = 0;
            bool canIAdd = true;
            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i] == '"')
                {
                    canIAdd = !canIAdd;
                }
                if (i == buf.Length - 1)
                {
                    arr.Add(buf.Substring(previous, i - previous + 1));
                }
                else if ((buf[i] == ' ' && canIAdd))
                {
                    arr.Add(buf.Substring(previous, i - previous));
                    previous = i + 1;
                }
            }
            return arr;
        }
    }
}
