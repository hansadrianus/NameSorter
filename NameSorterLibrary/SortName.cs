using NameSorterLibrary.Name;
using NameSorterLibrary.Sort;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorterLibrary
{
    public class SortName
    {
        public static string InputFile()
        {
            Console.Write("Please insert the data: ");
            string input = Console.ReadLine();

            return input;
        }

        public static IList<string> ReadData(string data)
        {
            IList<string> names = File.ReadLines(data).ToArray();

            Console.WriteLine("Unsorted name list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            return names;
        }

        public static void Sort(IList<string> source, List<NameModel> result)
        {
            SortProcessor sortProcessor = new SortProcessor();

            foreach (var name in source)
            {
                result.Add(sortProcessor.AppendData(name));
            }

            Console.WriteLine("Sorted name list:");
            foreach (var sort in result.OrderBy(q => q.IndexName).ThenBy(q => q.FullName))
            {
                Console.WriteLine(sort.FullName);
            }
        }
    }
}
