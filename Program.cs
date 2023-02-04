namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();

        ReEnteringApp:
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to view all the contacts in Address book\n"+
                "Press 3:   to Edit Contact\n"+
                "Press 4:   To Remove Exsiting Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();
                    break;
                case 2:
                    contact.ListPeople();
                    break;
                case 3:
                    contact.EditPerson();
                    break;
                case 4:
                    contact.RemovePerson();
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;
        }
    }
}
