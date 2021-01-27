using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.TcNo + " : " + customer.CustomerNo + " | " + customer.Name+ " | " + customer.Surname + " | " + customer. Age+ " | " + customer.CustomerProfession + " | " + customer.CustomerPhoneNum + "  Addeed.");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine( customer.CustomerNo +"th"+" customer record deleted!!");
        }

        public void List(Customer customer)
        {
            
            {
                Console.WriteLine(customer.TcNo);
                Console.WriteLine(customer.CustomerNo);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.CustomerProfession);
                Console.WriteLine(customer.CustomerPhoneNum);
            }
        }
    }
}
