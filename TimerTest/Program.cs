using OneShotTimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");


            Console.WriteLine("Do new timer");

            _ = new OST(Thisone,3);

            Console.ReadKey();
        }

        public static void Thisone()
        {

            Console.WriteLine("Method Called ! ");

        }
    }
}
