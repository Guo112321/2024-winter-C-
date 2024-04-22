using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class SelectionState : IVendingMachineState
    {
        public void SelectProduct(VendingMachine vendingMachine, string product)
        {
            Console.WriteLine($"Product {product} is already selected. Please insert money.");
        }

        public void InsertMoney(VendingMachine vendingMachine, decimal amount)
        {
            Console.WriteLine($"Money inserted: {amount}.");
            vendingMachine.SetState(new DispensingState());
        }

        public void DispenseProduct(VendingMachine vendingMachine)
        {
            Console.WriteLine("Please insert money to dispense the product.");
        }
    }
}
