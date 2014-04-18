using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "2014-04-16+02:00";

            Console.WriteLine(DateTime.Parse(s));
            if (s.Length == "2014-04-16+02:00".Length)
            {
                if (s[4] == '-' && s[7] == '-' && s[10] == '+' && s[13] == ':' && s.StartsWith("20") && s.EndsWith("+02:00") )
                {
                    s = s.Replace("+02:00", "");
                    string[] parts = s.Split('-');
                    DateTime result = new DateTime(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                    s = result.ToString();
                }
            }

            Console.WriteLine(DateTime.Parse(s) );
            Console.ReadLine();
        }
    }
}
