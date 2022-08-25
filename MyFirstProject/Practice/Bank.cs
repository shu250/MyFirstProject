using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Practice
{
   class Account
    {
        private int accNo;
        private string name;
        private string moNo;
        private string adharNo;
        private string gender;
        private int age;
        private double balance;
        public int AccNo
        {
            get;
            set;
        }
        public String Name
        {
            set;
            get;
        }
        public String MobNo
        {
            set;
            get;

        }
        public String AdharNo
        {
            set;
            get;
        }
        public string Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public double Balance
        {
            get;
            set;
        }
    }
    interface IRbible
    {
        public abstract void createAccount();
        public abstract void displayAllDetails();
        public abstract void displayMoney();
        public abstract void withdrawal();
        public abstract void balanceCheck();
        public abstract void depositeBalance();
    }
    class Sbi : IRbible
    {
       Account a = new Account();
       public void createAccount()
        {
           a. AccNo = 10001;
            a.AccNo++;
            Console.WriteLine("Enter Name:");
            a.Name = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number:");
            a.MobNo = Console.ReadLine();
            Console.WriteLine("Enter AdharNumber:");
            a.AdharNo = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            a.Gender = Console.ReadLine();
            Console.WriteLine("Enter age:");
            a.Age = int.Parse(Console.ReadLine());
            a.Balance = 1000;

        }
       public void displayAllDetails()
        {
            Console.WriteLine("Account Number:"+a.AccNo+"\nName:"+a.Name+"\nMobile Number:"+a.MobNo+"\nAdhar Number:"+a.AdharNo+"\nAge:"+a.Age);
        }
        public void displayMoney()
        {
            Console.WriteLine("Total Balance:"+a.Balance);
        }
        public void withdrawal()
        {
            Console.WriteLine("Enter Withdrow Amount:");
            double w = double.Parse(Console.ReadLine());
            if (a.Balance >= w)
            {
                a.Balance = a.Balance - w;
            }
            else
            {
                Console.WriteLine("Balance Not Available");
            }
        }
        public void balanceCheck()
        {
            this.displayMoney();
        }
        public void depositeBalance()
        {
            Console.WriteLine("Enter Deposite Amount:");
            double d = double.Parse(Console.ReadLine());
            a.Balance = a.Balance + d;
            
        }

    }

    class Test
    {
        static void Main(string[] args)
        {
            IRbible r = new Sbi();
            char c;
            do
            {

                Console.WriteLine("1.Create Account \n2.Display Detail\n3.Deposite Money\n4.WithDraw\n5.Balance");
                Console.WriteLine("Enter Your Choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        r.createAccount();
                        break;
                    case 2:
                        r.displayAllDetails();
                        break;

                    case 3:
                        r.depositeBalance();
                        break;
                    case 4:
                        r.withdrawal();
                        break;
                    case 5:
                        r.displayMoney();
                        break;

                    default:
                        Console.WriteLine("Enter Valid Input");
                        break;

                }
                Console.WriteLine("Do you want to start Process Plese Enter Y|N");
                c = char.Parse(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
        }
    }
      
}


