using System;

namespace Abstraction
{
    abstract class JLPTprop
    {
        private int maxQuestions = 10;
        public int minQuestions = 5;
        public abstract void dispMinQuestions();
        public void dispMaxQuestions()
        {
            Console.WriteLine(maxQuestions);
        }
    }
    class getJLPTprop : JLPTprop
    {
        public override void dispMinQuestions()
        {
            Console.WriteLine(minQuestions);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            getJLPTprop jlptprop = new getJLPTprop();
            jlptprop.dispMinQuestions();
            jlptprop.dispMaxQuestions();
          
        }
    }
}
