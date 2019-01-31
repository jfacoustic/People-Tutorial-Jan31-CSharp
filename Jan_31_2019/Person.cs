using System;

namespace Person
{
    public class Person : Name, IContact
    {
        protected string PhoneNum;
        public override string ToString()
        {
            return base.ToString() + " : " + PhoneNum;
        }
        public Person(string phoneNum, string firstName, string lastName) : base(firstName, lastName)
        {
            PhoneNum = phoneNum;
            First = firstName;
            Last = firstName;
        }
        public void SentText(Person receiver)
        {
            Console.WriteLine("Sending Text to " + receiver.ToString());
            Console.WriteLine("Sent.");
        }
    }
}
