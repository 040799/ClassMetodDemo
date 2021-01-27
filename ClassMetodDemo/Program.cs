using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.TcNo = "12345678912";
            customer1.CustomerNo = 6;
            customer1.Name = "Eda";
            customer1.Surname = "Gurgen";
            customer1.Age = 21;
            customer1.CustomerProfession = "Software Engineer";
            customer1.CustomerPhoneNum = 05123456789;

            Customer customer2 = new Customer();
            customer2.TcNo = "98765432109";
            customer2.CustomerNo = 9;
            customer2.Name = "Ayhan";
            customer2.Surname = "Gurgen";
            customer2.Age = 52;
            customer2.CustomerProfession = "businessman";
            customer2.CustomerPhoneNum = 05987654321;


            Customer customer3 = new Customer();
            customer3.TcNo = "12345678998";
            customer3.CustomerNo = 1;
            customer3.Name = "Elif";
            customer3.Surname = "Gurgen";
            customer3.Age = 27;
            customer3.CustomerProfession = "teacher";
            customer3.CustomerPhoneNum = 05998765432;


            Customer[] customer = new Customer[] { };

            CustomerManager customerManager = new CustomerManager();

            //customerManager.Add(customer1);
            //customerManager.Add(customer2);
            //customerManager.Add(customer3);

            //customerManager.Delete(customer2);

            //customerManager.List(customer1);

            while (true)
            {
                Console.WriteLine("Welcome to our system.");
                Console.WriteLine("1-add my customer record");
                Console.WriteLine("2-delete my customer record");
                Console.WriteLine("3-show my customer registration list");
                Console.WriteLine("4-exit");
                Console.WriteLine("Please select the action you want to do: ");
                var veri = Console.ReadLine();
                Console.WriteLine(veri);

                string islem = Convert.ToString(Console.ReadLine());

                if (islem == "1")
                {
                    customerManager.Add(customer1);
                }

                if(islem == "2")
                {
                    customerManager.Delete(customer2);
                }

                if (islem == "3")
                {
                    customerManager.List(customer1);
                }
                if(islem == "4")
                {
                    Console.WriteLine("you logged out");
                }
                break;
            }

        }
    }
}
