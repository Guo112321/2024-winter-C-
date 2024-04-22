using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class ChipsDispenser : ProductDispenserTemplate
    {
        protected override void CheckProductAvailability()
        {
            Console.WriteLine("Checking chips availability...");
        }

        protected override void VerifyPayment()
        {
            Console.WriteLine("Verifying payment for chips...");
        }

        protected override void DispenseProduct()
        {
            Console.WriteLine("Dispensing chips...");
        }
    }
}
