using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    //Hiçbir Sınıf Çıplak Bırakılmayacak.Interface ile implemente olacak.
    class CustomerManager:ICustomerService
    {

        public void Join(Customer customer)
        {
            if (customer.BirthYear < 2003)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " yeni kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Üzgünüz sayın " + customer.FirstName + " " + customer.LastName + "." + " " + "18 Yaşından Küçüklerin Sistemimize kaydolması yasaktır.");
            }

        }


        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı kayıt silindi.");

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı kayıt güncellendi.");

        }


    }
}
