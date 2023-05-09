

namespace ModelClasses
{
    public class Client
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string country;
        private string phoneNumber;

        public int ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Country { get => country; set => country = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Client(string firstName, string lastName, string address, string country, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Country = country;
            this.PhoneNumber = phoneNumber;
        }
        public Client()
        {

        }

    }
}
