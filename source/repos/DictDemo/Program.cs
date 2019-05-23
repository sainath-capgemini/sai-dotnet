using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDemo
{
    class Program
    {
        public void Show(int empno)
        
            {
                Dictionary<int, string> dicEmp = new Dictionary<int, string>();
                dicEmp.Add(1, "a");
                dicEmp.Add(3, "b");
                dicEmp.Add(2, "c");
                string res = string.Empty;
                dicEmp.TryGetValue(empno, out res);
                Console.WriteLine("result is" + res);
            }
             static void Main(string[] args)
            {
                Console.WriteLine("enter emp no");
                int empno = Convert.ToInt32(Console.ReadLine());
                new Program().Show(empno);
            }

        }
    }
