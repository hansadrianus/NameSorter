using NameSorterLibrary;
using NameSorterLibrary.Accounts;
using NameSorterLibrary.Person;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.Welcome();
            StandardMessage.AddLine(1);

            Console.Write("Please insert the data: ");
            //string data = Console.ReadLine();
            string data = "C:/Users/hanshersiono/source/repos/NameSorter/xUnitTest/File/unsorted-names-list.txt";

            StandardMessage.Clear();

            //Read the data
            IList<string> names = File.ReadLines(data).ToArray();

            Console.WriteLine("Unsorted name list:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //End read the data

            StandardMessage.AddLine(3);

            List<PersonModel> people = new List<PersonModel>();
            Accounts account = new Accounts();

            foreach (var name in names)
            {
                people.Add(account.Append(name));
            }

            foreach (var sort in people.OrderBy(q => q.IndexName).ThenBy(q => q.FullName))
            {
                Console.WriteLine(sort.FullName);
            }
        }
    }
}
