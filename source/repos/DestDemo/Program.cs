using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestDemo
{
    class Program
    {
        static Program()
        {
            Console.WriteLine(" static contructors");
        }
        public Program()
        {
            Console.WriteLine("instance constr");
        }
        ~Program()
        {
            Console.WriteLine("destructor fired");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
        }
    }
}
