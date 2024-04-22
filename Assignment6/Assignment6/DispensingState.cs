using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class DispensingState : IVendingMachineState
    {
        public void SelectProduct(VendingMachine vendingMachine, string product)
    {
        Console.WriteLine("Currently dispensing another product. Please wait.");
    }

    public void InsertMoney(VendingMachine vendingMachine, decimal amount)
    {
        Console.WriteLine("Currently dispensing a product. Unable to accept more money.");
    }

    public void DispenseProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Dispensing the product. Thank you!");
        vendingMachine.SetState(new IdleState());
    }
    }
}
