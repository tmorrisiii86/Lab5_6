using System;

namespace Lab5_6_Thomas_Morris
{
    class Program
    {
        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool isMember;
        }

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Joe";
            customer1.last_name = "Ravine";
            customer1.age = 19;
            customer1.isMember = false;

            customer2.first_name = "Gerald";
            customer2.last_name = "Benson";
            customer2.age = 25;
            customer2.isMember = false;

            customer3.first_name = "Ronald";
            customer3.last_name = "Steele";
            customer3.age = 43;
            customer3.isMember = true;

            Customer[] everyCustomer = { customer1, customer2, customer3 };

            for (int i = 0; i < everyCustomer.Length; i++)
            {
                if(everyCustomer[i].age < 21)
                {
                    Console.WriteLine(everyCustomer[i].first_name + " " + everyCustomer[i].last_name +
                        " is underage.  Order can not be placed.");
                }

                else
                {
                    Console.WriteLine(everyCustomer[i].first_name + " " + everyCustomer[i].last_name +
                        "'s order has been placed.");
                }

                if(everyCustomer[i].isMember == true)
                {
                    Console.WriteLine(everyCustomer[i].first_name + " " + everyCustomer[i].last_name +
                        " is a premium member.");
                }

                else
                {
                    Console.WriteLine(everyCustomer[i].first_name + " " + everyCustomer[i].last_name +
                        " is a standard member");
                }
            }
        }
    }
}
