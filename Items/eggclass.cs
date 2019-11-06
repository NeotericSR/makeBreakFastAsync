using System;
using System.Threading.Tasks;
using makeBreakFastAsyn.Items.data;

namespace makeBreakFastAsyn.Items
{
    public class Egg
    {
         public static async Task<Egg> FryEggsAsync(int howMany)
        {
            string[] position = Position.GetPosition();

            Console.WriteLine("Warming the egg pan...");

            for(int x = 0; x < howMany; x++){
                await Task.Delay(3000);
                Console.WriteLine(string.Format("cracking {0} egg", position[x]));
            }
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
            Console.WriteLine("eggs are ready");
            return new Egg();
        }
    }
}