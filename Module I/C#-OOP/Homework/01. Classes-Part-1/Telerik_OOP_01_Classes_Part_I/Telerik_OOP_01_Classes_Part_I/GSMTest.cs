using System;

namespace Telerik_OOP_01_Classes_Part_I
{
    public class GSMTest
    {
        public static void TestGSMClass()
        {
            GSM[] gsmArray =
            {
            new GSM("P8 Light", "Huwawei",580, "Sophie", new Battery("4000 mAh", 816, 46, BatteryType.LiPo), new Display(5, 16000000)),
            new GSM("Desire S","HTC", 200, "Anastasia", new Battery("1230 mAh", 821, 10, BatteryType.LiIon), new Display(3.5, 16000000)),
            new GSM("GalaxyS7", "Samsung", 1100, "Simon", new Battery("3000 mAh", 44, 22, BatteryType.LiIon), new Display(5.1, 16000000)),
            new GSM("150", "Alcatel", 60, "Liza", new Battery("1020 mAh", 744, 22, BatteryType.LiIon), new Display(2.4, 65000))
             };

            foreach (GSM gsm in gsmArray)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.IPhone);
        }
    }
}
