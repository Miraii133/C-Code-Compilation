using System;

namespace Basic_OOP
{

    class jlptroles
    {

    }
     class Program : jlptroles
    {
        static void Main(string[] args)
        {
            ContactInfo contactInfo = new ContactInfo();
            string[] lastName = { "Valmoria", "Mercado", "Del Mundo", "Estores" };
            contactInfo.setlastName(lastName);

            int length = contactInfo.getlastName().Length;
            for (int i = 0; i < length; i++)
            {
              string[] a =  contactInfo.getlastName();
                Console.WriteLine(a[i]);
            }
           

        }
    }
}
