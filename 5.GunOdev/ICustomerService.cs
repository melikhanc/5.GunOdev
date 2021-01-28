using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    interface ICustomerService
    {

        void Join(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);

    }
}
