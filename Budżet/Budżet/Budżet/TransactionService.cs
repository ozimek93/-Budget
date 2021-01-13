using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet
{
   public class TransactionService
    {
        private List<Transaction> Transactions { get; set; }

        public TransactionService()
        {
            Transactions = new List<Transaction>();
        }
    
    public decimal InComeTransaction()
        {
            Transaction inTransaction = new Transaction();

            Console.WriteLine("What is the transaction amount?");
            decimal amount = decimal.Parse(Console.ReadLine());
            inTransaction.Value = amount;

            Console.WriteLine("What was the transaction?");
            string transactionName = Console.ReadLine();
            inTransaction.Name = transactionName;
            inTransaction.TypeId = 1;

            Transactions.Add(inTransaction);
            return amount;
        }
        public decimal OutComeTransaction()
        {
            Transaction outTransaction = new Transaction();

            Console.WriteLine("What is the transaction amount?");
            decimal amount = decimal.Parse(Console.ReadLine());
            outTransaction.Value = amount;

            Console.WriteLine("What was the transaction?");
            string transactionName = Console.ReadLine();
            outTransaction.Name = transactionName;
            outTransaction.TypeId = 2;

            Transactions.Add(outTransaction);
            return amount;
        }

         public int TransactionList()
         {
             List<Transaction> ListOfTransaction = new List<Transaction>();
             ListOfTransaction = Transactions;
             int transactionCounter = 1;
           foreach (var transaction in ListOfTransaction)
             {
                 Console.WriteLine($"{transactionCounter}. {transaction.Name}. Kwota transakcji: {transaction.Value}");
                 transactionCounter++;
             }
             return transactionCounter;
         }
        
      
    }
}
