using System;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class Battery
    {
        // Encapsulated fields

        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        // Constructors

        public Battery(string batteryModel, BatteryType batteryType, double? hoursIdle = null, double? hoursTalk = null)
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
        }

        public Battery(string batteryModel, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        // Properties

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery model cannot be null or empty!");
                }
                this.batteryModel = value;
            }
        }
        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle cannot be negative!");
                }
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk cannot be negative!");
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    }
}
