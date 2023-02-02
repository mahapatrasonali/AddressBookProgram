namespace AddressBook
{
    public class Program
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To The Address Book Program");
        }
        public static void CreatingContact()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            double phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Email_Id");
            string emailId = Console.ReadLine();
            Console.WriteLine($"\n First Name : {firstName}\n Last Name : {lastName}\n Address : {address}\n Phone Number : {phoneNo}\n Email ID : {emailId}");
        }
        public static void Main(string[] args)
        {
            WelcomeMessage();
            CreatingContact();
        }
    }
}
