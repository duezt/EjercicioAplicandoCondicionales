namespace LINQPractice
{
    public class SeedData
    {
        List<Person> people = new List<Person>
        {
             new Person { Id = 1, Name = "John", Age = 25, City = "New York" },
             new Person { Id = 2, Name = "Jane", Age = 30, City = "London" },
             new Person { Id = 3, Name = "Bob", Age = 22, City = "Paris" },
             new Person { Id = 4, Name = "Alice", Age = 28, City = "New York" },
             new Person { Id = 5, Name = "Charlie", Age = 35, City = "London" },
             new Person { Id = 6, Name = "Diana", Age = 27, City = "Paris" }
         };
            
        List<Order> orders = new List<Order>
        {
            new Order { Id = 1, PersonId = 1, Product = "Laptop", Price = 1000 },
            new Order { Id = 2, PersonId = 2, Product = "Phone", Price = 500 },
            new Order { Id = 3, PersonId = 1, Product = "Tablet", Price = 300 },
            new Order { Id = 4, PersonId = 3, Product = "Headphones", Price = 100 },
            new Order { Id = 5, PersonId = 4, Product = "Camera", Price = 800 },
           new Order { Id = 6, PersonId = 2, Product = "Smartwatch", Price = 200 }
        };

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }

        public class Order
        {
            public int Id { get; set; }
            public int PersonId { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
        }
    }
}