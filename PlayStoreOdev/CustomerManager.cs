using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStoreOdev
{
    class CustomerManager  
    {

        
        public void Add(Customer customer, AccountVerification accountVerification)
        {
            Console.WriteLine(customer.FirstName +
                " isimli kişinin doğrulanması için E-Devlet sistemine yönlendiriliyor...");
            accountVerification.Verification();
            Console.WriteLine("---> Kullanıcı bilgisi <---\n");
            Console.WriteLine("Kullanıcı Id: " + customer.Id);
            Console.WriteLine("Kullanıcı ismi: "+ customer.FirstName);
            Console.WriteLine("Kullanıcı soyismi: " + customer.LastName);
            Console.WriteLine("Kullanıcı Tc: " + customer.Tc);
            Console.WriteLine("Kullanıcı doğum tarihi: " + customer.DateOfBirth + "\n");
            


        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "isimli kullanıcı bilgisi güncellendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("*" + customer.FirstName + " " + customer.LastName + "* isimli kullanıcı hesabı başarıyla silindi");
        }

        
    }
}
