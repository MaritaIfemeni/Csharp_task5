
namespace src.Users
{
    public abstract class Person
    {
        private int _id { get; }
        private string? _name;
        private string? _emailAddress;

        public Person(int id, string name, string emailAddress)
        {
            _id = GenerateUniqueId();
            _name = name;
            _emailAddress = emailAddress;
        }
        public int Id
        {
            get { return _id; }
        }
        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string? EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public int GenerateUniqueId()
        {
            Random random = new Random();
            return random.Next(1, 10000);
        }

    }
}