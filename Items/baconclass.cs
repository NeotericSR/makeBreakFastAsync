using System.Threading.Tasks;
using System;
using makeBreakFastAsyn.Items.data;

namespace makeBreakFastAsyn.Items
{
    public class Bacon
    {
         public static async Task<Bacon> FryBaconAsync(int slices)
        {
            string[] pos = Position.GetPosition();
            Console.WriteLine(string.Format($"putting {slices} slice{0} of bacon in the pan", slices > 1 ? 's': ' '));
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++){
                Console.WriteLine(string.Format("flipping {0} slice of bacon", pos[slice]));
                Console.WriteLine("cooking the second side of bacon...");
                await Task.Delay(3000);
                Console.WriteLine(string.Format("Put {0} bacon on plate", pos[slice]));
            }
            Console.WriteLine("All bacon is ready");
            return new Bacon();
        }
    }
}