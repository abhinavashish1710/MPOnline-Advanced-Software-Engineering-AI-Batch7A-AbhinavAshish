using System;

namespace Assignment02_Shopping
{
    // Base Class
    class User
    {
        protected string name;

        public User(string name)
        {
            this.name = name;
        }

        public void DisplayUser()
        {
            Console.WriteLine("User: " + name);
        }
    }

    // Customer Class
    class Customer : User
    {
        private string order;
        private double payment;

        public Customer(string name) : base(name)
        {
        }

        public void PlaceOrder(string item)
        {
            order = item;
            Console.WriteLine(name + " placed an order for " + order);
        }

        public void MakePayment(double amount)
        {
            payment = amount;
            Console.WriteLine("Payment of ₹" + payment + " successful.");
        }
    }

    // Delivery Agent Class
    class DeliveryAgent : User
    {
        public DeliveryAgent(string name) : base(name)
        {
        }

        public void DeliverOrder()
        {
            Console.WriteLine(name + " delivered the order.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Abhinav");
            customer.DisplayUser();
            customer.PlaceOrder("Laptop");
            customer.MakePayment(65000);

            Console.WriteLine();

            DeliveryAgent agent = new DeliveryAgent("Rahul");
            agent.DisplayUser();
            agent.DeliverOrder();
        }
    }
}