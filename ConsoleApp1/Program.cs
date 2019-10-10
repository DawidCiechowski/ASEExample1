using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            Console.WriteLine(app.example1());
            Console.WriteLine(app.example2());
        }




        public string example1()
        {
            return "This is an example";
        }

        public string example2()
        {
            return "This is another example";
        }

        public string example3()
        {
            return "LOL";
        }
    }
}

