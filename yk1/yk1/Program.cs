using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yk1
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Char> list = new List<Char>();
            string str= Console.ReadLine();        
            for (int i = 0; i < str.Length; i++)
            {
                list.Add(str[i]);
        
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.ReadKey();
        }
    }
}
