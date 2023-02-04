using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactList
    {
        Contact contact = new Contact();
        List<Contact> people = new List<Contact>();
     
        public void AddPerson()     //Adding Person .
        {
            contact = new Contact();
            Console.WriteLine("Enter your First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your email id");
            contact.emailId = Console.ReadLine();
            people.Add(contact);
        }
        public void ListPeople()        //List of all Contacts/People's.
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your Address book is empty. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people found in your address book :");
            foreach (var person in people)
            {
                Console.WriteLine($"\n First Name : {contact.firstName}\n Last Name : {contact.lastName}\n Address : {contact.address}\n Phone Number : {contact.phoneNo}\n Email ID : {person.emailId}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
