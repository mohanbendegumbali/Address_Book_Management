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
        public void EditContact(string name)
        {
            foreach(var contact in address)
                if (contact.FirstName.Equals(name) || (contact.LastName.Equals(name)))
                {
                    Console.WriteLine(" Enter what you want to edit " + "\n" + " Select 1.Address" + "\n" + "2.City" + "\n" + "3.State" + "\n" + "4.PhoneNumber" + "\n" + "5.Zip" + "\n" + "6.Email Id");
                    int option=Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(" Enter the Address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine(" Enter the City ");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine(" Enter the state ");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine(" Enter the Phone Number ");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine(" Enter the Zip ");
                            contact.Zip=Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine(" Enter the Mail Id ");
                            contact.Email = Console.ReadLine();
                            break;


                    }
                }
            
        }
    }
}
