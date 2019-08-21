using System;

namespace InterfaceExmple
{
    interface Itransaction 
    {
        void showTransactions();
        double getAmount();
    }

    class transaction : Itransaction
    {
        double amount;
        string date;
        string code;

        public transaction()
        {
            amount = 0;
            date = "";
            code = "";
        }
        public transaction(double Amount, string Date , string Code)
        {
            amount = Amount;
            date = Date;
            code = Code;

        }
        public void showTransactions()
        {
            Console.WriteLine("Amount: "+ getAmount());
            Console.WriteLine("Date: "+date);
            Console.WriteLine("Transaction code: "+code );
        }

        public double getAmount()
        {
            return amount;
        }
    }
    class Program
    {
        static void Main()
        {
            transaction transaction = new transaction(1200,"12/12/2018","12x2345");
            transaction transaction1 = new transaction(1300, "12/12/2018", "12x2346");

            transaction.showTransactions();
            Console.WriteLine("\n");
            transaction1.showTransactions();
            Console.ReadKey();
        }
    }
}
