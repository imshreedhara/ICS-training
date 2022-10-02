using System;

namespace Assignment_03
{
    /* 1.Create a class called Accounts which has data members like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
	    D->Deposit
	    W->Withdrawal

	-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the credit(int amount) function and update balance
	-If transaction type is withdraw call debit(int amt)function and update balance

	-Pass the other information like Acount no, name, acc type through constructor
	-call the show data method to display the values. */

    class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public char TransactionType;
        public int Amount;
        public int Balance=50000;
        public char d = 'd'; 
        public char w = 'w';      


        static void Main(string[] args)
        {
            Accounts bankEx = new Accounts(12345, "shreedhara", "savingsAcc");

            Console.WriteLine("Account Details");
            bankEx.ShowData();

            Console.WriteLine("Please enter the transaction Type (d for deposit / w for withdrawal) :");
            bankEx.TransactionType = Convert.ToChar(Console.ReadLine()); // "d"/ "w"

            Console.WriteLine("enter the amount : ");
            bankEx.Amount = Convert.ToInt32(Console.ReadLine());
            
            bankEx.Balance= bankEx.TransType(bankEx.Amount, bankEx.TransactionType);
            Console.WriteLine("After the Transaction the Account Details are : ");

            bankEx.ShowData();

            Console.ReadKey();         
        }

        public Accounts(int accNo, string name, string accType)
        {
            AccountNo = accNo;
            CustomerName = name;
            AccountType = accType;           
        }
        
        public int TransType(int amt,char transactionType)
        {
            if (transactionType == d)
            {
                Console.WriteLine("Amount Credited : "+ amt);
                return AmtCredit(amt);
            }

            else if (transactionType == w)
            {
                Console.WriteLine("Amount Debited : " + amt);
                return AmtDebit(amt);
            }

            else
            {
                Console.WriteLine("Enter valid Transaction Type : ");
                return 0;
            }

        }

        public int AmtCredit(int amtValue)
        {
            Balance = Balance + amtValue;
            return Balance;           
        }

        public int AmtDebit(int amtValue)
        {
            Balance = Balance - amtValue;
            return Balance;
        }

        public void ShowData()
        {
            Console.WriteLine("Acc No :{0}\nCustomer Name :{1}\nAcc type : {2}\nbalance : {3}", AccountNo,CustomerName,AccountType,Balance);
        }
    }
}
