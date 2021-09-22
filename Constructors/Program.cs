using System;

namespace Constructors
{
    class studentGrades
    {
        // constructor
        private int grade;
        public studentGrades(int _studentGrade)
        {
             grade = _studentGrade;
            
        }
        public int getGrades()
        {
            int getGrade = grade;
            return getGrade;
        } 

    }
    class Program
    { 
        static void Main(string[] args)
        {
            studentGrades SG = new studentGrades(15);
            Console.WriteLine(SG.getGrades());
        }
    }
}
