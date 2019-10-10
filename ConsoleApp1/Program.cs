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
            string[] b = { "A", "B", "C" };
            Program app = new Program();
            Console.WriteLine(app.example1());
            Console.WriteLine(app.example2());
            Console.WriteLine(app.return_number(3, 4));
            while (true) { }
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

        public int return_number(int a, int b)
        {
            return a + b;
        }

        public void z()
        {
 
        }
            
    }
}

