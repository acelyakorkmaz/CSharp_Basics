using System;

namespace Constructor_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor bir claası new'lediğimizde bir kere çalışır 
            Customer customer1 = new Customer { Id=1,Name="Açelya",LastName="Korkmaz",City="Trabzon"};
            Customer customer2 = new Customer { Id = 2, Name = "Ada", LastName = "Uysal", City = "İstanbul" };
            Console.WriteLine(customer2.Name);
        }

        class Customer
        {
            //default constructor
            public Customer()
            {
                    
            }
            public Customer(int id,string name,string lastName, string city)
            {
                 id=Id;
                Name = name;
                LastName = lastName;
                City = city;

            }


            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

           

        }

    }
}
