using System;

namespace NameSorterLibrary
{
    public class StandardMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome Name Sort!");
            Console.WriteLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void AddLine(int p)
        {
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
