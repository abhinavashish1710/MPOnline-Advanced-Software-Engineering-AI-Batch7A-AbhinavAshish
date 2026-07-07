using System;

namespace Assignment4_ShoppingDiscounts
{
    class Discount
    {
        public virtual double CalculateDiscount(double amount)
        {
            return amount;
        }
    }

    class PrimeDiscount : Discount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount - (amount * 0.20);
        }
    }

    class LoyaltyDiscount : Discount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount - (amount * 0.10);
        }
    }

    class OtherDiscount : Discount
    {
        public override double CalculateDiscount(double amount)
        {
            return amount - (amount * 0.05);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Shopping Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose Discount Type");
            Console.WriteLine("1. Prime Discount");
            Console.WriteLine("2. Loyalty Discount");
            Console.WriteLine("3. Other Discount");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Discount discount;

            switch (choice)
            {
                case 1:
                    discount = new PrimeDiscount();
                    break;

                case 2:
                    discount = new LoyaltyDiscount();
                    break;

                case 3:
                    discount = new OtherDiscount();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            double finalAmount = discount.CalculateDiscount(amount);

            Console.WriteLine("\nOriginal Amount : " + amount);
            Console.WriteLine("Final Amount    : " + finalAmount);
        }
    }
}