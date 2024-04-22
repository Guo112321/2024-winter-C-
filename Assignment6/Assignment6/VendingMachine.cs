using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class VendingMachine
    {
        private IVendingMachineState _currentState;
        public Dictionary<string, Product> Products { get; set; }
        public Product SelectedProduct { get; private set; }

        public VendingMachine()
        {
            _currentState = new IdleState();
            Products = new Dictionary<string, Product> {
                { "soda", new Product("Soda", 1.25m, 10) },
                { "chips", new Product("Chips", 1.00m, 5) }
            };
        }

        public void SetState(IVendingMachineState newState)
        {
            _currentState = newState;
        }

        public void SelectProduct(string productName)
        {
            if (Products.TryGetValue(productName, out Product product))
            {
                SelectedProduct = product;
                _currentState.SelectProduct(this, productName);
            }
            else
            {
                Console.WriteLine("Product does not exist.");
            }
        }

        public void InsertMoney(decimal amount)
        {
            _currentState.InsertMoney(this, amount);
        }

        public void DispenseProduct()
        {
            _currentState.DispenseProduct(this);
        }
    }
}
