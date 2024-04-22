using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public interface IVendingMachineState
    {
        void SelectProduct(VendingMachine vendingMachine, string product);
        void InsertMoney(VendingMachine vendingMachine, decimal amount);
        void DispenseProduct(VendingMachine vendingMachine);
    }
}
