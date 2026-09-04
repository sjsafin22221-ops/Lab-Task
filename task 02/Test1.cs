using System;

namespace SmartBankingSystem
{
    enum AccountType
    {
        Savings,
        Current,
        PremiumSavings
    }

    struct Address
    {
        public string City;
        public string Country;

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        public void Display()
        {
            Console.WriteLine("Address : " + City + ", " + Country);
        }
    }

    class Account
    {
        protected string name;
        protected double balance;
        protected Address address;
        protected AccountType type;

        public static string BankName;

        static Account()
        {
            BankName = "ABC Smart Bank";

        }
        public Account() : this("Unknown", 0)
        {
            Console.WriteLine("Default Constructor");
        }
        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
            address = new Address("Dhaka", "Bangladesh");
        }
        public Account(Account obj)
        {
            name = obj.name;
            balance = obj.balance;
            address = obj.address;
            type = obj.type;
        }
        ~Account()
        {
            Console.WriteLine("Destructor Executed");
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposit : " + amount);
        }

        public void Deposit(ref double amount)
        {
            balance += amount;
            amount = 0;
            Console.WriteLine("Deposit using ref");
        }

        public void Deposit(double amount, out double total)
        {
            balance += amount;
            total = balance;
            Console.WriteLine("Deposit using out");
        }

        public void Deposit(params double[] amounts)
        {
            foreach (double x in amounts)
            {
                balance += x;
            }

            Console.WriteLine("Deposit using params");
        }
        public virtual double CalculateInterest()
        {
            return balance * 0.02;
        }

        public virtual void Display()
        { 
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Balance : " + balance);
            Console.WriteLine("Interest : " + CalculateInterest());
            address.Display();
        }
    }

    class SavingsAccount : Account
    {
        public SavingsAccount(string n, double b)
            : base(n, b)
        {
            type = AccountType.Savings;
            Console.WriteLine("Savings Constructor");
        }

        public override double CalculateInterest()
        {
            return balance * 0.06;
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(string n, double b)
            : base(n, b)
        {
            type = AccountType.Current;
            Console.WriteLine("Current Constructor");
        }
        public new double CalculateInterest()
        {
            return 0;
        }

        public override void Display()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Balance : " + balance);
            Console.WriteLine("Interest : " + CalculateInterest());
            address.Display();
        }
    }

    class PremiumSavings : SavingsAccount
    {
        public PremiumSavings(string n, double b)
            : base(n, b)
        {
            type = AccountType.PremiumSavings;
            Console.WriteLine("Premium Constructor");
        }

        public sealed override double CalculateInterest()
        {
            return balance * 0.10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Name : " + Account.BankName);

            Account a1 = new Account("Rahim", 10000);

            Account copy = new Account(a1);

            SavingsAccount s = new SavingsAccount("Karim", 50000);

            CurrentAccount c = new CurrentAccount("Sakib", 70000);

            PremiumSavings p = new PremiumSavings("Hasan", 100000);

            Console.WriteLine("\n===== Runtime Polymorphism =====");

            Account obj;

            obj = s;
            Console.WriteLine("Savings Interest = " + obj.CalculateInterest());

            obj = p;
            Console.WriteLine("Premium Interest = " + obj.CalculateInterest());

            obj = c;
            Console.WriteLine("Current Interest (Base) = " + obj.CalculateInterest());

            Console.WriteLine("Current Interest (Hidden) = " + c.CalculateInterest());

            Console.WriteLine("\n===== Deposit =====");

            a1.Deposit(1000);

            double amount = 500;
            a1.Deposit(ref amount);

            Console.WriteLine("Amount after ref = " + amount);

            double total;
            a1.Deposit(0, out total);

            Console.WriteLine("Balance = " + total);

            a1.Deposit(100, 200, 300);

            Console.WriteLine("\n===== Single Dimensional Array =====");

            Account[] accounts = { a1, s, c, p };

            foreach (Account item in accounts)
            {
                item.Display();
            }

            Console.WriteLine("Length = " + accounts.Length);

            Console.WriteLine("\n===== Two Dimensional Array =====");

            int[,] matrix =
            {
                {1,2,3},
                {4,5,6}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n===== Jagged Array =====");

            int[][] jagged =
            {
                new int[]{1,2},
                new int[]{3,4,5},
                new int[]{6,7,8,9}
            };

            foreach (int[] row in jagged)
            {
                foreach (int value in row)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}