using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class IdleState : IVendingMachineState
    {
        public void SelectProduct(VendingMachine vendingMachine, string product)
        {
            Console.WriteLine($"Product {product} selected.");
            vendingMachine.SetState(new SelectionState());
        }

        public void InsertMoney(VendingMachine vendingMachine, decimal amount)
        {
            Console.WriteLine("Please select a product first.");
        }

        public void DispenseProduct(VendingMachine vendingMachine)
        {
            Console.WriteLine("No product selected to dispense.");
        }
    }
}
