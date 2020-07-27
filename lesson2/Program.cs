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
        static void FuncDouble()
        {
            float a = 0.75f;
            a += 1;
            float b = 3f / 4;
            decimal c = 0.75M;
            if (c == 3M / 4 )
            { 
                Console.Write("Yes");
                Console.WriteLine(a+" "+b);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void FuncEnum(Toyota model1, Toyota model2)
        {
            if (model1 == Toyota.Prius)
            {
                Console.WriteLine(Toyota.Prius.ToString());
            }
        }
        enum Toyota
        {
            Corolla,
            Prius,
            Lexus
        }
        static void Main(string[] args)
        {
            FuncEnum(Toyota.Prius, Toyota.Prius);
            FuncDouble();
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
