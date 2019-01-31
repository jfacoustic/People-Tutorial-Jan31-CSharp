using System;

namespace People
{
    public class Faculty : Person
    {
        private readonly int EmployeeID;

        public Faculty(string phoneNum, string firstName, string lastName, int ID) : base(phoneNum, firstName, lastName) 
        {
            PhoneNum = phoneNum;
            First = firstName;
            Last = lastName;
            EmployeeID = ID;        
        }
    }
}
