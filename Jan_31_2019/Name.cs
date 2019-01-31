using System;

namespace People
{
    public class Name
    {
        protected string First;
        protected string Last;

        public override string ToString()
        {
            return Last + ", " + First;
        }
        public Name( string first, string last )
        {
            First = first;
            Last = last;
        }
    }
}
