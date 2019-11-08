using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletareTema2Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLinii;
            Console.WriteLine("Insert file adress");
            var b = Console.ReadLine();
            string[] name = File.ReadAllLines(b);
            totalLinii = int.Parse(name[0]) + int.Parse(name[1]);
            var a = new StreamWriter(b, true);
            a.WriteLine("\n Sum: " + totalLinii);
            a.Close();
            Console.ReadLine();
        }
    }
}
