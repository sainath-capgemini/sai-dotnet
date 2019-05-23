using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class Program
    {
        public void Check(string user, string pwd)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("a", "b");
            users.Add("h", "l");
            users.Add("d", "g");
            string res = string.Empty;
            users.TryGetValue(user, out res);
            if (res.Equals(pwd))
            {
                Console.WriteLine("correct credentials");

            }
            else
            {
                Console.WriteLine("invalid credentials");
            }
        }
        static void Main(string[] args)
        {
            string pwd, user;
            Console.WriteLine("enter un and pwd");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            new Program().Check(user, pwd);
        }
    }
}
