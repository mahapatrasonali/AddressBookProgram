using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public void EditPerson()    //Editing Contact .
        {
        findingPersonAgain:
            Console.WriteLine("Enter the first name of person to be removed");
            string verifyingFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of person to be removed");
            string verifyingLastName = Console.ReadLine();
            foreach (var person in people)
            {
                if (person.firstName.Equals(verifyingFirstName) && person.lastName.Equals(verifyingLastName))   //Editing Contact if exists.
                {
                moreEditing:
                    Console.WriteLine("Please select any one as per the below given options on which you want the modification \n" +
                        "1)First Name\n2)Last Name\n3)Address\n4)Phone Number\n5)Email_Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter your first name : ");
                            person.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last name : ");
                            person.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address : ");
                            person.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your Phone Number : ");
                            person.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Please enter your email Id: ");
                            person.emailId = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("You've selected an Invalid Option!");
                            Console.WriteLine("Do you want to try again ");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                goto findingPersonAgain;
                            }
                            break;
                    }
                    Console.WriteLine("Do you want to do any more modification in the same contact Y/N \n");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        goto moreEditing;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That person could not be found.Do you want to try again ");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        goto findingPersonAgain;
                    }
                    return;
                }
            }
        }
             public void RemovePerson()      //Delete an existing Contact 
            {
                Console.WriteLine("Enter the first name of person to be removed");
                string verifyingFirstName = Console.ReadLine();
                Console.WriteLine("Enter the last name of person to be removed");
                string verifyingLastName = Console.ReadLine();
                foreach (var person in people)
                {
                    if (person.firstName.Equals(verifyingFirstName) && person.lastName.Equals(verifyingLastName))
                    {
                        Console.WriteLine("Are you sure you want to remove this person from your address book ? (Y/N)");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            people.Remove(person);
                            Console.WriteLine("Person removed .Press any key to continue.\n");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That person could not be found.Press any key to continue to try again ");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        public void CreateDictionaryContact()
        {
            Console.WriteLine("Enter name to add AddressBook");
            string name = Console.ReadLine();
           // Contact.Add(name, contact);
            
        }


    }
}
