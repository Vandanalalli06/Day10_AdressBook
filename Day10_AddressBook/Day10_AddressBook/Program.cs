
using Day10_AddressBook;

namespace AdressBook
{
    class program
    {


        public static void Main(string[] args)
        {
            AddressBook address = new AddressBook();
            address.AddNewContact();
            Console.WriteLine();
            address.Display();
        }
    }
}