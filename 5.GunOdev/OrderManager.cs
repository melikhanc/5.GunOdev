using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    class OrderManager : IOrderService
    {
        public void Refund(Order order, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu, " + order.GameName + " oyununu, iade etti." );
        }

        public void Sale1(Order order, Campaign campaign, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu, " + order.GameName + " oyununu," +order.Price + " TL yerine " +campaign.CampaignName + " kampanyası ile " + "%" +
             campaign.DiscountRate+ " indirim ile" + (order.Price - (order.Price * campaign.DiscountRate/100 )) + " TL ile satın aldı.");
        }

        public void Sale2(Order order, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu, " + order.GameName + " oyununu," + order.Price + " fiyatıyla satın aldı.");
        }
    }
}
