using System;

namespace People
{
    public class Student : Person
    {
        private readonly int StuID;
        public Student(string phoneNum, string firstName, string lastName, int stuID) : base(phoneNum, firstName, lastName)
        {
            PhoneNum = phoneNum;
            First = firstName;
            Last = lastName;
            StuID = stuID;
        }
    }
}
