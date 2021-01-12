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

        public static void Enter()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public static void AddLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
