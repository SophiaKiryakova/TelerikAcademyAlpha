using System;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class Display
    {
        // Encapsulated fields

        private double size;
        private long numberOfColors;

        // Constructors

        public Display(double size, long? numberOfColors = null)
        {
            this.Size = size;
        }
        public Display(double size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        // Properties

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size must be bigger than 0!");
                }
                this.size = value;
            }
        }
        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors must be bigger than 0!");
                }
                this.numberOfColors = value;
            }
        }
    }
}
