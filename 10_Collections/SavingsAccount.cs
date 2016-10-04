using System;

namespace _10_Collections
{
    internal class SavingsAccount: IAsset
    {
        private double balance = 0;

        public SavingsAccount()
        {

        }

        public SavingsAccount(string accountname, double balance, double interestrate)
        {
            this.InterestRate = interestrate;
            this.balance = balance;
            this.Name = accountname;
        }
        public double InterestRate
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public double GetValue()
        {
           
            return this.balance ;
        }

        public override string ToString()
        {
            return "SavingsAccount[" + "value="+ this.balance + ",interestRate="  + this.InterestRate + "]" ;
        }

        public void ApplyInterest()
        {
            this.balance += (this.balance / 100) * this.InterestRate;
            
        }
    }
}