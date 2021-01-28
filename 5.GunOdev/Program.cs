using System;

namespace _5.GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer { BirthYear = 1988, Id = 1, FirstName = "Melikhan", LastName = "Çelebi", IdentityNumber = 1234567 };
            Customer customer2 = new Customer { BirthYear = 1970, Id = 2, FirstName = "Mahmut", LastName = "Çelebi", IdentityNumber = 150247 };
            Customer customer3 = new Customer { BirthYear = 2010, Id = 3, FirstName = "Berkesu", LastName = "Aksu", IdentityNumber = 196301 };


            CustomerManager customerManager = new CustomerManager();
            customerManager.Join(customer1);
            customerManager.Join(customer2);
            customerManager.Join(customer3);
            Console.WriteLine("*******************************");

            Campaign campaign1 = new Campaign { CampaignName = "Steam Yılbaşı İndirimi", DiscountRate = 40 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine("-------------------------------------");
            Order order1 = new Order { GameName = "Call Of Duty Black Ops", Price = 150 };
            


            OrderManager orderManager = new OrderManager();
            orderManager.Sale1(order1,campaign1,customer1);

            


        }
    }
}
