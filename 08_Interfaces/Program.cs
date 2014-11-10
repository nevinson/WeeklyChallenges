using _08_Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Nevinson",
                LastName = "Moyo",
                City = "Johannesburg",
                EmailAddress = "me@nevinson.com",
                PhoneNumber = "073-602-2982"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "Nevinson T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });

            return output;
        }
    }
}
