using NameSorterLibrary;
using NameSorterLibrary.Export;
using NameSorterLibrary.Name;
using NameSorterLibrary.Sort;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace xUnitTest
{
    public class SortNameTest
    {
        [Fact]
        public void SortLastName()
        {
            StandardMessage.Welcome();
            StandardMessage.AddLine(1);

            string data = SortName.InputFile();
            IList<string> names = SortName.ReadData(data);
            List<NameModel> people = new List<NameModel>();

            StandardMessage.Enter();
            StandardMessage.Clear();

            SortName.Sort(names, people);

            StandardMessage.AddLine(1);

            ExportSortedNames.Export(people);
        }

        [Fact]
        public IList<string> ReadData()
        {
            string data = "../../../File/unsorted-names-list.txt";
            IList<string> names = File.ReadLines(data).ToArray();

            return names;
        }

        [Fact]
        public static void Sort()
        {
            string data = "../../../File/unsorted-names-list.txt";
            IList<string> source = File.ReadLines(data).ToArray();

            List<NameModel> result = new List<NameModel>();
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

        [Fact]
        public static void Export()
        {
            string data = "../../../File/unsorted-names-list.txt";
            IList<string> source = File.ReadLines(data).ToArray();

            List<NameModel> result = new List<NameModel>();
            SortProcessor sortProcessor = new SortProcessor();

            foreach (var name in source)
            {
                result.Add(sortProcessor.AppendData(name));
            }

            Console.Write("Specify export directory: ");
            string path = "../../../File";
            FileStream stream = new FileStream(path + "/sorted-names-list.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(stream);
            TextWriter textWriter = Console.Out;

            Console.SetOut(writer);
            foreach (var sort in result.OrderBy(q => q.IndexName).ThenBy(q => q.FullName))
            {
                Console.WriteLine(sort.FullName);
            }
            Console.SetOut(textWriter);
            writer.Close();
            stream.Close();
            Console.WriteLine("File exported with name sorted-names-list.txt");
        }
    }
}
