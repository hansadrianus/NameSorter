using NameSorterLibrary.Person;

namespace NameSorterLibrary.Accounts
{
    public interface IAccounts
    {
        PersonModel Append(string person);
    }
}