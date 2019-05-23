using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Arthematic
    {
        public void Sum(int x, double y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, double y)
        {
            Console.WriteLine(x - y);
        }
        public void Mul(int x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, double y)
        {
            Console.WriteLine(x / y);
        }
        public void Mod(int x, double y)
        {
            Console.WriteLine(x % y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value");
            int r = Convert.ToInt32(Console.ReadLine());
            Arthematic sai = new Arthematic();
            switch(r)
            {
                case 1:sai.Sum(a, b);break;
                case 2: sai.Sub(a, b); break;
                case 3: sai.Mul(a, b); break;
                case 4: sai.Div(a, b); break;
                case 5: sai.Mod(a, b); break;
                default: Console.WriteLine("invalid operations");break;
            }

        }
    }
}
