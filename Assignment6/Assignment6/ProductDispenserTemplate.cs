
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public abstract class ProductDispenserTemplate
    {
        public void Dispense()
        {
            CheckProductAvailability();
            VerifyPayment();
            DispenseProduct();
        }

        protected abstract void CheckProductAvailability();
        protected abstract void VerifyPayment();
        protected abstract void DispenseProduct();
    }
}
