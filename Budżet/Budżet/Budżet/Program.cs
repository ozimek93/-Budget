using System;

namespace Budżet
{
    class Program
    {

        static void Main(string[] args)
        {
            MenuService actionService = new MenuService();
            actionService = Initialize(actionService);
            

            Console.WriteLine("Welcome to the home budget app");
            Console.WriteLine("Enter your current account balance: ");

            decimal balance = decimal.Parse(Console.ReadLine());
            while (true)
            {
            
            Console.WriteLine("What do you want to do?");

            var mainMenu = actionService.getMenuActionByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

                var choice = Console.ReadKey();
                Console.WriteLine();
                TransactionService transactionService = new TransactionService();
                switch (choice.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Please select transaction type: ");
                        var transaction = actionService.getMenuActionByMenuName("Transaction");
                        for (int i = 0; i<transaction.Count;i++ )
                        {
                            Console.WriteLine($"{transaction[i].Id}. {transaction[i].Name}");
                        }
                        choice = Console.ReadKey();
                        Console.WriteLine();
                        switch (choice.KeyChar)
                        {
                            case '1':
                                decimal inComeTransaction = transactionService.InComeTransaction();
                                balance = balance + inComeTransaction;
                                break;
                            case '2':
                                decimal outComeTransaction = transactionService.OutComeTransaction();
                                balance = balance - outComeTransaction;
                                break;
                            default:
                                Console.WriteLine("There is no such option. Please selecet again.");
                                break;
                        }
                        break;
                    case '2':
                        Console.WriteLine($"Aktualne saldo wynosi {balance}");
                        break;
                    case '3':
                        transactionService.TransactionList();
                        break;
                    default:
                        Console.WriteLine("There is no such option. Please selecet again.");
                        break;
                }

            } 
        }

        private static MenuService Initialize (MenuService actionService)
        {
            actionService.AddNewAction(1, "transaction", "Main");
            actionService.AddNewAction(2, "balance", "Main");
            actionService.AddNewAction(3, "transaction summary", "Main");

            actionService.AddNewAction(1, "income", "Transaction");
            actionService.AddNewAction(2, "outgo", "Transaction");
           
            return actionService;

        }
        
       
    }
}
