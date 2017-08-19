using System;

namespace mathChallenge
{
    internal class MaxLengthAttribute : Attribute
    {
        private int v;

        public MaxLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}