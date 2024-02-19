using System;
namespace Ex16
{
    public class PaymentCard
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public PaymentCard(double balance)
        {
            Balance = balance;
        }

        public override string ToString()
        {
            return "The card has a balance of " + balance + " pounds";
        }
    }
}

