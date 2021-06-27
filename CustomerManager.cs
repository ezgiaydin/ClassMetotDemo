using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine(musteri.customerId + " " + musteri.customerName + " " + musteri.customerSurname);
        }
        public void List(Customer liste)
        {
            Console.WriteLine(liste.customerId + " " + liste.customerName + " " + liste.customerSurname);
        }
        public void Delete(Customer sil)
        {
            Console.WriteLine(sil.customerId + " " + sil.customerName + " " + sil.customerSurname);
        }
    }
}


