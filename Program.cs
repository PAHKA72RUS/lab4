using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obyect = new ArrayList() { 32, 25.3, 3, "l", 9.7, "t", "Z", "Q", 855, 1, "j", "H", 15, 14.5, 0 };
            ArrayList obyectVverh = new ArrayList(100);

            for (int i = 0; i < obyect.Count; i++)
            {
                Console.Write(obyect[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < obyect.Count; i++)
            {
                if (obyect[i] is string)
                {
                    obyect.RemoveAt(i);
                    if (obyect[i] is string) i--;
                }
            }

            for (int i = 0; i < obyect.Count; i++)
            {
                Console.Write(obyect[i] + " | ");
            }
        }
    }
}