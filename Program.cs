using System;
using System.Threading.Tasks;
using makeBreakFastAsyn.Items;

namespace makeBreakFastAsyn
{
    class Program
    {
        static readonly string juice = "Apple";
        static readonly string coffeeType = "Mocha";

        static async Task Main(string[] args)
        {
            // make breakfast 
            Coffee cup = Coffee.PourCoffee(coffeeType);
            Task<Egg> eggTask = Egg.FryEggsAsync(2);
            Task<Bacon> baconTask = Bacon.FryBaconAsync(3);
            Task<Toast> toastTask = Toast.ToastBreadAsync(2);
            Toast toast = await toastTask;
            /*
                ApplyButter(toast);
                ApplyJam(toast);
            */
            await toast.MakeToastWithButterAndJamAsync(2);
            
            Juice oj = Juice.PourJuice(juice);
            Egg eggs = await eggTask;
            Bacon bacon = await baconTask;

            Console.WriteLine("Breakfast is ready!");
        }
    }
}
