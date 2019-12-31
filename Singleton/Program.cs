using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            setIn s = setIn.Inestance;
        }
    }
    public sealed class setIn
    {
        static readonly setIn inst = new setIn();
        public static setIn Inestance
        {
            get
            {
                return inst;
            }
        }
        setIn()
        {

        }
    }
}
