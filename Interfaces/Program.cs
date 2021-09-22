using System;

namespace Interfaces
{

    interface IgetJLPTprop
    {
        public int getMaxQuestion();
        public int getMinQuestion();
        public int getPassScore();
    }
    class errorJLPTprop : IgetJLPTprop
    {
        private string errmaxQuestion = "Error! No maximum questions";
        private string errminQuestion = "Error! No minimum questions";
        private string errpassScore = "Error! No pass score!";
        public int getMaxQuestion()
        {
            Console.WriteLine(errmaxQuestion);
            return 0;
        }
        public int getMinQuestion()
        {
            Console.WriteLine(errminQuestion);
            return 0;
        }
        public int getPassScore()
        {
            Console.WriteLine(errpassScore);
            return 0;
        }
    }

    class getJLPTprop : IgetJLPTprop
    {
        private int maxQuestion = 35;
        private int minQuestion = 5;
        private int passScore = 17;
        public int getMaxQuestion()
        {
            return maxQuestion;
        }
        public int getMinQuestion()
        {
            return minQuestion;
        }
        public int getPassScore()
        {
            return passScore;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            getJLPTprop jlptProp = new getJLPTprop();
            int maxQuestion = jlptProp.getMaxQuestion();
            int minQuestion = jlptProp.getMinQuestion();
            int passScore = jlptProp.getPassScore();
            Console.WriteLine(maxQuestion);
            Console.WriteLine(minQuestion);
            Console.WriteLine(passScore);;

            errorJLPTprop errProp = new errorJLPTprop();
            errProp.getMaxQuestion();
            errProp.getMinQuestion();
            errProp.getPassScore();
          
        }
    }
}
