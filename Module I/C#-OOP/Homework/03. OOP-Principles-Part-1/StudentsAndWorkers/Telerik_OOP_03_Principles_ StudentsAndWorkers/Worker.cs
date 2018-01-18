using System.Text;

namespace Telerik_OOP_03_Principles__StudentsAndWorkers
{
    public class Worker: Human
    {
        public Worker(string firstName, string secondName, decimal weekSalary, double workHoursPerDay) : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; private set; }
        public double WorkHoursPerDay { get; private set; }

        public decimal CalculateMoneyPerHour()
        {
            return this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5);
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append($" Week salary: {this.WeekSalary:F2}, ");
            sb.Append($"Work hours per day: {this.WorkHoursPerDay}, ");
            sb.Append($"Money per hour: {this.CalculateMoneyPerHour():F2}");
            return sb.ToString();
        }
    }
}
