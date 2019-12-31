using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_BaseN
{
    class Convert
    {
        int NumBase;
        const string dig = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ+-";
        public int radix
        {
            set
            {
                if (value < 2 || value > 64)
                    throw new ArgumentException("The radix must be >= 2 and <= 64");
                NumBase = value; 
            }
        } 

        public Convert(int n = 10)
        {
            NumBase = 10;
        }

        public string ForDc(int val)
        {
            int m = 0;
            var sb = new StringBuilder();
            do
            {
                m = val % NumBase;
                sb.Insert(0, dig[m]);
                val = (val - m) / NumBase;
            } while (val > 0);

            return sb.ToString();
        }
        public long ToDc(string val)
        {
            if (String.IsNullOrEmpty(val))
                return 0;
            long rsult = 0;
            long mul = 1;
            for(int i=val.Length - 1; i>=0; i--)
            {
                char c = val[i];
                if (i == 0 && c == '-')
                {
                    rsult = -rsult;
                    break;
                }
                int d = dig.IndexOf(c);
                if (d == -1)
                {
                    throw new ArgumentException("Not Valied");
                }
                rsult += (d * mul);
                mul *= NumBase;
            }
            return rsult;
        }
    }
}
