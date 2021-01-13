using NameSorterLibrary.Name;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorterLibrary.Sort
{
    public class SortProcessor
    {
        public NameModel AppendData(string person)
        {
            NameModel model = new NameModel();

            model.FullName = person;
            model.IndexName = person.Split(" ", StringSplitOptions.RemoveEmptyEntries).Last();

            return model;
        }
    }
}
