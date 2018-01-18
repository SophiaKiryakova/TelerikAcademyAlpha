using System;

namespace Telerik_OOP_03_Principles_Part_02_RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;
        private string message;

        public InvalidRangeException(T start, T end, string message)
        {
            this.start = start;
            this.end = end;
            this.message = "The correct range is between ";
        }

        public override string Message
        {
            get
            {
                return this.message + this.start + " and " + this.end;
            }
        }
    }
}
