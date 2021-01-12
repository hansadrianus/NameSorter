using NameSorterLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace xUnitTest
{
    public class SortName
    {
        [Fact]
        public void SortLastName()
        {
            string data = "../../../File/unsorted-names-list.txt";

            IList<string> names = File.ReadLines(data).ToArray();

            Console.WriteLine("Unsorted name list:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            StandardMessage.AddLine(3);

            List<string> sortedNames = new List<string>(names);
            sortedNames.Sort();

            Console.WriteLine("Sorted name list:");
            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
