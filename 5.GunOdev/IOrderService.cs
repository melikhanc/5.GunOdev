using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    interface IOrderService
    {
        void Sale1(Order order, Campaign campaign, Customer customer);

        void Sale2(Order order, Customer customer);
        
        void Refund(Order order, Customer customer);

    }
}
