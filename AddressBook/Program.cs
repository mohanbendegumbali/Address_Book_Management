using System; // Import's

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Management ");
            AddressBookMain create = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact" + "\n" + "2.Edit Contact" + "\n" + "3.Delete Contact" + "\n" + "4.Display Contact" + "\n" + "5.Create Dictionary" + "\n" + "6.Display Dictionary");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        create.CreateContact();
                        break;
                    case 2:
                        create.EditContact();
                        break;
                    case 3:
                        create.DeleteContact();
                        break;
                    case 4:
                        create.Display();
                        break;
                    
                }
            }
        }
    }
}


