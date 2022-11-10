using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> address = new List<Contact>();
        Contact contact = new Contact();
        public void CreateContact()
        {
            Console.WriteLine(" Enter the first name ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine(" Enter the last name ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine(" Enter the address ");
            contact.Address = Console.ReadLine();
            Console.WriteLine(" Enter the city ");
            contact.City = Console.ReadLine();
            Console.WriteLine(" Enter the state ");
            contact.State = Console.ReadLine();
            Console.WriteLine(" Enter the Phone number ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine(" Enter the Email Id ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter the Zip");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            address.Add(contact);
        }
    }
}
