
   





using System;

namespace Encap
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
            Console.WriteLine(id);
        }
    }
    class testProperty
    {
        public int minQuestions;
        public int maxQuestions;
        public int passScore;
        public int failScore;
    }

    class Program : testProperty
    {
        static void Main(string[] args)
        {
            jlptroles jlptID = new jlptroles();
           jlptID.getjlptID();

            testProperty testProperty = new testProperty();
            testProperty.maxQuestions = 5;
            int currmaxQuestions = testProperty.maxQuestions;
            Console.WriteLine(currmaxQuestions);

            testProperty setTestProperty = new testProperty();
            setTestProperty.maxQuestions = 10;
            int newmaxQuestions = setTestProperty.maxQuestions;
            Console.WriteLine(newmaxQuestions);


        }
    }
}
