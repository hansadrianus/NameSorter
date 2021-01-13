using NameSorterLibrary;
using NameSorterLibrary.Sort;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NameSorterLibrary.Name;
using NameSorterLibrary.Export;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
