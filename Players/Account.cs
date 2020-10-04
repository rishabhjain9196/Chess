namespace Chess.Players
{
    public class Account
    {
        public string emailAddress;

        public Name name;

        public AccountType accountType;
    }


    public enum AccountType 
    {
        Freemium,
        Paid
    }

    public class Name 
    {
        public string firstName;
        public string middleName;
        public string lastName;
    } 
}
