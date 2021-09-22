using System;

namespace FamilyInfo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Last name: ");
            string _lastName = Console.ReadLine();
            Console.WriteLine("First name: ");
            string _firstName = Console.ReadLine();
            Console.WriteLine("Middle name: ");
            string _middleName = Console.ReadLine();
            Console.WriteLine("Age:");
            int _age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contact number: ");
            string _contactNum = Console.ReadLine();
            Console.WriteLine(_contactNum);
            FamilyInfo familyInfo = new FamilyInfo();
            familyInfo.setFamilyInfo(_lastName, _firstName, _middleName, 
                _age, _contactNum) ;


            string info = familyInfo.getFamilyInfo();
            Console.WriteLine(info);
        }
    }
}
