using System;
using System.Threading.Tasks;

namespace makeBreakFastAsyn.Items
{
    public class Coffee
    {
        public static Coffee PourCoffee(string type)
        {
            Console.WriteLine(string.Format("Pouring {0} coffee", type));
            Console.WriteLine(string.Format("{0} coffee is ready", type));
            return new Coffee();
        }
    }
}