using System;
using System.Threading.Tasks;
using makeBreakFastAsyn.Items.data;

namespace makeBreakFastAsyn.Items
{
    public class Toast
    {
        static string[] position = Position.GetPosition();
        public async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast, number);
            ApplyJam(toast, number);
            Console.WriteLine("toast is ready");
            return toast;
        }

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++){
                Console.WriteLine(string.Format("Putting {0} slice of bread in the toaster", position[slice]));
                Console.WriteLine("Start toasting...");
                await Task.Delay(3000);
                Console.WriteLine(string.Format("Remove toast{0} from toaster", slice > 0 ? 's' : ' '));
            }
               
            return new Toast();
        }

        private static void ApplyJam(Toast toast, int number = 1) => Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast,  int number = 1) => Console.WriteLine("Putting butter on the toast");
    }
}