using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace lesson2
{
    class Program
    {
       static void Func()
       {
            sbyte a = -100;
            byte b = 5;
            short c = (short)(b + a);
            Console.WriteLine(c + " type " + c.GetType());
       }
        static void Main(string[] args)
        {
            Func();
            Writer.Write();
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            salmons.Add("coho");
            salmons.Add("sockeye");
            salmons.Add("coho");

            salmons.RemoveAll(coho);

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }

            static bool coho(String s)
            {
                return s == "coho" || s == "sockeye";
            }
        }
    }
}
