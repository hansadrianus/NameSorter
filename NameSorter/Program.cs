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

            string path = "C:/Users/hanshersiono/source/repos/NameSorter/xUnitTest/File/sorted-names-list.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(stream);
            TextWriter textWriter = Console.Out;

            StandardMessage.Clear();

            //Read the data
            IList<string> names = File.ReadLines(data).ToArray();

            Console.WriteLine("Unsorted name list:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            StandardMessage.Enter();
            StandardMessage.Clear();

            List<PersonModel> people = new List<PersonModel>();
            Accounts account = new Accounts();

            foreach (var name in names)
            {
                people.Add(account.Append(name));
            }

            Console.WriteLine("Sorted name list:");
            foreach (var sort in people.OrderBy(q => q.IndexName).ThenBy(q => q.FullName))
            {
                Console.WriteLine(sort.FullName);
            }

            Console.SetOut(writer);
            Console.WriteLine("Sorted name list:");
            foreach (var sort in people.OrderBy(q => q.IndexName).ThenBy(q => q.FullName))
            {
                Console.WriteLine(sort.FullName);
            }            
            Console.SetOut(textWriter);
            writer.Close();
            stream.Close();
            Console.WriteLine("File exported with name sorted-names-list.txt");
            StandardMessage.Enter();
        }
    }
}
