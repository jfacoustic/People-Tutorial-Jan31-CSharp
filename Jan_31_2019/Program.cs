using System;
using Person;

namespace Jan_31_2019
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person s = new Student("867-4309", "Jenny", "Doe", 1234567890);
            Person f = new Faculty("123-4567", "John", "Dobbs", 987654321);
            Console.WriteLine(s.ToString());
            Console.WriteLine(f.ToString());
            s.SentText(f);
            f.SentText(s);
            f.SentText(f);
        }
    }
}