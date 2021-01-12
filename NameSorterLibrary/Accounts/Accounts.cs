using NameSorterLibrary.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorterLibrary.Accounts
{
    public class Accounts : IAccounts
    {
        public PersonModel Append(string person)
        {
            PersonModel model = new PersonModel();
            model.FullName = person;
            model.IndexName = person.Split(" ", StringSplitOptions.RemoveEmptyEntries).Last();

            return model;
        }
    }
}
