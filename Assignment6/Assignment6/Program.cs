using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTests();
        }

        static void DisplayMenu()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Welcome to the Vending Machine!");

            while (true)
            {
                Console.WriteLine("\nAvailable commands:");
                Console.WriteLine("1. Select a product");
                Console.WriteLine("2. Insert money");
                Console.WriteLine("3. Dispense the product");
                Console.WriteLine("4. Exit the application");
                Console.Write("Enter a number to choose an action: ");
                string input = Console.ReadLine();

                try
                {
                    int command;
                    if (int.TryParse(input, out command))
                    {
                        switch (command)
                        {
                            case 1:
                                Console.Write("Enter product name: ");
                                string product = Console.ReadLine();
                                if (!string.IsNullOrEmpty(product))
                                    vendingMachine.SelectProduct(product);
                                else
                                    Console.WriteLine("Please specify a product to select.");
                                break;
                            case 2:
                                Console.Write("Enter amount to insert: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                                    vendingMachine.InsertMoney(amount);
                                else
                                    Console.WriteLine("Please specify a valid amount of money to insert.");
                                break;
                            case 3:
                                vendingMachine.DispenseProduct();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Invalid command. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid command number.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static void RunTests()
        {
            VendingMachine vm = new VendingMachine();
            Console.WriteLine("Running Tests...");

            vm.SelectProduct("soda");
            vm.InsertMoney(1.25m);
            vm.DispenseProduct();

            vm.SelectProduct("chips");
            vm.InsertMoney(1.00m);
            vm.DispenseProduct();

            Console.WriteLine("Tests completed successfully.\n");
        }
    }
}
