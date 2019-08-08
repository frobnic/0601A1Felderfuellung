using System;

namespace _0601A1Felderfuellung
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] feld = new sbyte[10];
            Random zuf = new Random();

            for (int i = 0; i < 10; i++)
                feld[i] = (sbyte)(i + 1);

            foreach (int n in feld)
                Console.Write($"{n} ");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                feld[i] = (sbyte)(10 - i);

            foreach (int n in feld)
                Console.Write($"{n} ");
            Console.WriteLine();


            for (int i = 0; i < 10; i++)
                feld[i] = (sbyte)zuf.Next(0, 9);

            foreach (int n in feld)
                Console.Write($"{n} ");
            Console.WriteLine();


        }
    }
}
