using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyInfo_App
{
    public class FamilyInfo
    {
      
        private string lastName, firstName, middleName;
        private int age;
        private string contactNum;
        public string getFamilyInfo()
        {
            string familyInfo = lastName + " " + firstName + " " 
                    + middleName + " " + age + " " + contactNum;
            return familyInfo;
        }
        public void setFamilyInfo(string _lastName, string _firstName, 
            string _middleName, int _age, string _contactNum)
        {
            lastName = _lastName;
            firstName = _firstName;
            middleName = _middleName;
            age = _age;
            contactNum = _contactNum;
        }
    }
   
}
