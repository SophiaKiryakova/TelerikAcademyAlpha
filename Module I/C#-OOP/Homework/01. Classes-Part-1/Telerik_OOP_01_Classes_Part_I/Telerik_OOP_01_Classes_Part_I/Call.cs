using System;
using System.Text;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class Call
    {
        // Encapusuled fields

        private DateTime date;
        private DateTime time;
        private string dialledNumber;
        private int duration;

        // Constructor

        public Call(DateTime date, DateTime time, string dialledNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        // Properties

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }
            set
            {
                this.dialledNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Date: {this.Date.ToString("dd.MM.yyyy")}; Time: {this.Time.ToString("HH:mm:ss")};");
            sb.AppendLine($"Dialled number: {this.DialledNumber}; Duration: {this.Duration} seconds;");
            return base.ToString();
        }
    }
}
