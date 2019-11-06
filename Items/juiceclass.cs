using System;

namespace makeBreakFastAsyn.Items
{
    public class Juice
    {
        public static Juice PourJuice(String juice)
        {
            Console.WriteLine(string.Format("Pouring {0} Juice", juice));
            Console.WriteLine(string.Format("{0} is ready", juice));
            return new Juice();
        }
    }
}