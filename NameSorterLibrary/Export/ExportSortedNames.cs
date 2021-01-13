using NameSorterLibrary.Name;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorterLibrary.Export
{
    public class ExportSortedNames
    {
        public static void Export(List<NameModel> people)
        {
            Console.Write("Specify export directory: ");
            string path = Console.ReadLine();
            FileStream stream = new FileStream(path + "/sorted-names-list.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(stream);
            TextWriter textWriter = Console.Out;

            Console.SetOut(writer);
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
