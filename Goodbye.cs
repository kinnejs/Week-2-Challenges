using System;

namespace Week2
{
    internal class Goodbye
    {
        public static implicit operator Goodbye(Goodbuy v)
        {
            throw new NotImplementedException();
        }
    }
}