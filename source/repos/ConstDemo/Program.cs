using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDemo
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("static constructor");
        }
        public Program()
        {
            Console.WriteLine("instance consructor");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
        }
    }
}
