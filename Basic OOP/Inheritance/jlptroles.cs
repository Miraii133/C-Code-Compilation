using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_OOP.Inheritance
{
    public class jlptroles
    {
        private enum jlptID : long
        {
        N5 = (long)779928524341116929, 
        N4 = (long)779928531912097812,
        N3 = (long)779928533345501195,
        N2 = (long)779928536596217856,
        N1 = (long)779928538919993375
        }
        public void getjlptID()
        {
            long id = (long)jlptID.N5;
        }
    }
      
    
}
