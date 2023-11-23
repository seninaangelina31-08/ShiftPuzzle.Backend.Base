using System;

namespace Task3
{
    public class Contact
    {
        string name;
        string phoneNumber;

        public Contact(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public string ToString()
        {
            return "Contact name: " + name + "\nPhone number: " + phoneNumber + "\n";
        }
    }
}