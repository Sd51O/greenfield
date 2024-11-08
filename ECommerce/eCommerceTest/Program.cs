using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogue;
using CRM;
using OrderProcesssing;

namespace eCommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Customer customer = new Customer();
             customer.Id = 22;
             customer.FirstName = "samrudhee";
             customer.LastName = "More";
             customer.EmailId = "chetanmore@gmail.com";

             Customer customer1 = new Customer();
             customer1.Id = 23;
             customer1.FirstName = "mayank";
             customer1.LastName = "Awate";
             customer1.EmailId = "rajawate1307@gmail.com";

             iCusttomerService customerService = new CustomerService();
             customerService.Insert(customer);
             customerService.Insert(customer1);
             List<Customer> allCustomers = customerService.GetAll();
             foreach (Customer customerr in allCustomers)
             {
                 Console.WriteLine(customerr.Id);
                 Console.WriteLine(customerr.EmailId);
                 Console.WriteLine(customerr.LastName);
                 Console.WriteLine(customerr.FirstName);
             }*/
            /*Order Order1 = new Order();
            Order1.OrderId = 22;
            Order1.Status = "Delivered";
            Order1.Amount = 1000;
            Order1.Date = new DateTime(2023, 12, 10);

            Order Order2 = new Order();
            Order2.OrderId = 23;
            Order2.Status = "Reject";
            Order2.Amount = 4522;
            Order2.Date = new DateTime(2024, 12, 10);

            IOrderService1 OrderService = new OrderService();
            OrderService.Insert(Order1);
            OrderService.Insert(Order2);

            List<Order> allOrders = OrderService.GetAll();

            foreach (Order Order in allOrders)
            {
                Console.WriteLine(Order.OrderId);
                Console.WriteLine(Order.Date);
                Console.WriteLine(Order.Amount);
                Console.WriteLine(Order.Status);
            }
            Console.ReadLine();*/
            Product Product1 = new Product();
            Product1.PId = 22;
            Product1.Title = "Mobile";
            Product1.Description = " OnePlus 128GB 8GB RAM";
            Product1.ImageUrl = ("C:\\Users\\rutuja\\Documents\\SQL Server Management Studio\\SQL");
            Product1.UnitPrice = 450000;
            Product1.Quantity = 10;

            Product Product2 = new Product();
            Product2.PId = 22;
            Product2.Title = "Mobile";
            Product2.Description = " Redmi Note5 128 8GB";
            Product2.ImageUrl = ("C:\\Users\\samrudhee.deshmukh\\Documents\\SQL Server Management Studio\\SQL");
            Product2.UnitPrice = 10000;
            Product2.Quantity = 10;


            IProductService productService = new ProductService();
            // IOrderService OrderService = new OrderService();
            productService.Insert(Product1);
            //productService.Insert(Product2);

            List<Product> products = productService.GetAll();

            foreach (Product product in products)
            {
                Console.WriteLine(product.PId);
                Console.WriteLine(product.Title);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Quantity);
                Console.WriteLine(product.ImageUrl);
            }
            productService.Update(Product2);
           
            
            Console.ReadLine();



        }
    }
}
