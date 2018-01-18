using System;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            // Creating an instance of the GSM class

            GSM gsm = new GSM("GalaxyG5", "Samsung", 1100, "Bibi", new Battery("3000 mAh", 44, 22, BatteryType.NiCd), new Display(5.1, 586000000));

            // Creating a few calls

            Call firstCall = new Call((new DateTime(2017, 12, 19)), DateTime.Parse("19:32:12"), "01233532456", 210);
            Call secondCall = new Call((new DateTime(2015, 05, 01)), DateTime.Parse("15:12:52"), "6534343210", 1431);
            Call thirdCall = new Call((new DateTime(2014, 01, 31)), DateTime.Parse("23:37:03"), "12343434567", 353);

            // Adding the calls

            gsm.AddCalls(firstCall);
            gsm.AddCalls(secondCall);
            gsm.AddCalls(thirdCall);

            // Display the information about the calls
            
            Console.WriteLine($"Call history:\n{gsm.CallHistory}\n");

            // Display the total price of the calls

            Console.WriteLine($"Total price of the calls:\n{gsm.CalculateTotalPriceOfCalls()}\n");

            // Remove the longest call from the history and calculate the total price again.

            //gsm.RemoveCalls(gsm.callHistory[gsm.FindLongestCall()]);
            Console.WriteLine($"Total price of the calls without the longest call:\n{gsm.CalculateTotalPriceOfCalls()}\n");

            // Clear the call history and print it.
            gsm.ClearHistory();
            Console.WriteLine($"Call history without any calls:\n{gsm.CallHistory}\n");
        }
    }
}
