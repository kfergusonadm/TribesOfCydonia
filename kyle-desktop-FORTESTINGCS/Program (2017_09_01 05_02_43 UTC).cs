using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyle_desktop_FORTESTINGCS
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++) {
                System.Console.WriteLine(i);
                
            };
            System.Threading.Thread.Sleep(10000);
        }
    }
}
