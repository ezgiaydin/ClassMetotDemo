using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.customerId = 12345;
            c1.customerName = "ezgi";
            c1.customerSurname = "aydın";


            Customer c2 = new Customer();
            c2.customerId = 34567;
            c2.customerName = "deniz";
            c2.customerSurname = "aküzüm";


            Customer[] musteriler = new Customer[] { c1, c2 };
            foreach (var i in musteriler)
            {
                Console.WriteLine(i.customerId + "-" + i.customerName+ "" + i.customerSurname);
            }

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-----add costumer(s)----");
            customerManager.Add(c2);
            Console.WriteLine("----list of customers----");
            customerManager.List(c2);
            customerManager.List(c1);
            Console.WriteLine("----delete customer(s)----");
            customerManager.Delete(c1);

        }
    }
}
