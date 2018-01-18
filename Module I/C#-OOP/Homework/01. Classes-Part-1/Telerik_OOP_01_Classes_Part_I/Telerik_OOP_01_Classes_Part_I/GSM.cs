using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class GSM
    {
        // Encapsulated fields

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone = new GSM("4S", "Apple", 500, "Annie", new Battery("2300 mAh", BatteryType.LiIon, 10, 5), new Display(3.5, 50000000));
        private const decimal CallPricePerMinute = 0.37M;
        private List<Call> callHistory = new List<Call>();

        // Constructors

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        // Properties

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model name!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid manufacturer name!");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("GSM price should be bigger than 0!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model name!");
                }
                this.owner = value;
            }
        }
        public static string IPhone
        {
            get
            {
                return iPhone.ToString();
            }
        }

        // Property for Call History

        public StringBuilder CallHistory
        {
            get
            {
                StringBuilder sbCalls = new StringBuilder();
                if (this.callHistory.Count == 0)
                {
                    sbCalls.Append("Call history is empty");
                }
                else
                {
                    for (int i = 0; i < callHistory.Count; i++)
                    {
                        if (i == callHistory.Count - 1)
                        {
                            sbCalls.Append(callHistory[i].ToString());
                        }
                        else
                        {
                            sbCalls.AppendLine(callHistory[i].ToString());
                        }
                    }
                }
                return sbCalls;
            }
        }

        // Method for adding, removing calls from the history and clearing the entire history

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCalls(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        //  Method calculating the total price of the calls in the call history
        public string CalculateTotalPriceOfCalls()
        {
            var price = CallPricePerMinute * (callHistory.Sum(call => call.Duration) / 60m);
            return String.Format("{0:F2}lv.", price);
        }

        // Method finding the longest call
        public int FindLongestCall()
        {
            if (this.callHistory.Count != 0)
            {
                int indexLongestCall = 1;
                for (int index = 1; index < this.callHistory.Count; index++)
                {
                    if(this.callHistory[index].Duration > this.callHistory[index - 1].Duration)
                    {
                        indexLongestCall = index;
                    }
                }
                return indexLongestCall;
            }
            else
            {
                throw new ArgumentException("Calls' list is empty!");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Phone - model: {this.Model}, manufacturer: {this.Manufacturer}, price: {this.Price} lv., owner: {this.Owner}");
            sb.AppendLine($"Battery - model: {this.battery.BatteryModel}, hours idle: {this.battery.HoursIdle}, hours talking: {this.battery.HoursTalk}, type: {this.battery.BatteryType}");
            sb.AppendLine($"Display - size: {this.display.Size}, number of colors: {this.display.NumberOfColors}");

            return sb.ToString();
        }
    }
}
