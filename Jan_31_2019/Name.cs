using System;

namespace People
{
    public class Name
    {
        protected string First { get; set; }
        protected string Last { get; set; }

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
