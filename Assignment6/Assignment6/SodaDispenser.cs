using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class SodaDispenser : ProductDispenserTemplate
    {
        protected override void CheckProductAvailability()
        {
            Console.WriteLine("Checking soda availability...");
        }

        protected override void VerifyPayment()
        {
            Console.WriteLine("Verifying payment for soda...");
        }

        protected override void DispenseProduct()
        {
            Console.WriteLine("Dispensing soda...");
        }
    }
}
