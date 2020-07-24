using System;
using System.Collections.Generic;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
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
