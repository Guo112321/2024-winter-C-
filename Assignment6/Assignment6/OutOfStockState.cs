using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class OutOfStockState : IVendingMachineState
    {
        public void SelectProduct(VendingMachine vendingMachine, string product)
        {
            Console.WriteLine($"Sorry, {product} is out of stock.");
        }

        public void InsertMoney(VendingMachine vendingMachine, decimal amount)
        {
            Console.WriteLine("Product out of stock. Unable to accept money.");
        }

        public void DispenseProduct(VendingMachine vendingMachine)
        {
            Console.WriteLine("Product out of stock. Unable to dispense.");
        }
    }
}
