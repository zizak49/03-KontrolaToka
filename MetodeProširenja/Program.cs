using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] riječi = new string[] { "Franjo", "Ivana", "Dora", "Mirko" };
            Console.WriteLine(Pretraga.Sadrži(riječi, "Ivana"));

            int[] brojevi = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Pretraga.Zbroj(brojevi));


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
