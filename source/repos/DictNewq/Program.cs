using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictNewq
{
    class Program
    {
        public void Check(string name)
        {
            Dictionary<string, double> empDict = new Dictionary<string, double>();
            empDict["sai"] = 4789.25;
            empDict["nath"] = 478945.25;
            empDict["dela"] = 4789478.25;
            double res = 0;
            empDict.TryGetValue(name, out res);
            Console.WriteLine("result is"+res);
        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            new Program().Check(name);
        }
    }
}
