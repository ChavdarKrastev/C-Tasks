using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? noValue = null;
            double? nullValue = null;
            System.Console.WriteLine("This is null value:"+nullValue+"\n This is null value too:"+noValue);
            noValue = 5;
            nullValue = 0;
            System.Console.WriteLine("This is zero:" + nullValue + "\n This is five:" + noValue);

        }
    }
}
