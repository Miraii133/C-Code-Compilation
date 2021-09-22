using System;

namespace Inheritance
{
    class start
    {
        public void startProgram()
        {
            dispText dispTexts = new dispText();
            dispTexts.askRetQuestion();
        }
    }

    class testProperty
    {
        protected int maxQuestions = 5;
        protected int minQuestions;
        protected int passScore;
        protected int failScore;
        protected int allowPlayers;

    }
    class propMethods : testProperty
    {
        public string getChoice(int retChc)
        {
            string currChoice;

            if (retChc != 0 &&
                retChc > 0)
            {
                if (retChc == 1)
                {
                    currChoice = "chc_maxQuestions";
                    return currChoice;
                }
                if (retChc == 2)
                {
                    currChoice = "chc_minQuestions";
                    return currChoice;
                }
                if (retChc == 3)
                {
                    currChoice = "chc_passScore";
                    return currChoice;
                }
                if (retChc == 4)
                {
                    currChoice = "chc_failScore";
                    return currChoice;
                }
                if (retChc == 5)
                {
                    currChoice = "chc_allowPlayers";
                    return currChoice;
                }
            }
            return null;

        }
        public int getProperty(string currChoice)
        {
            int propData;
            if (currChoice == "chc_maxQuestions")
            {
                propData = maxQuestions;
                return propData;
            }
            if (currChoice == "chc_minQuestions")
            {
                propData = minQuestions;
                return propData;
            }
            if (currChoice == "chc_passScore")
            {
                propData = passScore;
                return propData;
            }
            if (currChoice == "chc_failScore")
            {
                propData = failScore;
                return propData;
            }
            if (currChoice == "chc_allowPlayers")
            {
                propData = allowPlayers;
                return propData;
            }
            // 1 = maxQuestions, 2 = minQuestions, 3 = passScore
            // 4 = failScore, 5 = allowPlayers
            return 0;
        }

        public void setProperty()
        {

        }

        public void dispProperty(int propData)
        {

            Console.WriteLine(propData);

        }
    }

   
    class dispText
    {
       string actChcQuestion = "Action [1] Get Property [2] Set Property :";
       string retPropQuestion = "Retrieve property: ";
       string selPropQuestion = "Selected property: ";

       string setPropQuestion = "Set property:";
       string newPropValue = "New property value:";

       int actionChc;
       int retChc;
       int setChc;


        public void askRetQuestion()
        {
            Console.WriteLine(actChcQuestion);
            actionChc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(retPropQuestion);
            retChc = Convert.ToInt32(Console.ReadLine());
            checkChoice();
        }

        public void askSetQuestion()
        {
            Console.WriteLine(setPropQuestion);
            setChc = Convert.ToInt32(Console.ReadLine());

        }
        public void checkChoice()
        {
            if (actionChc == 1)
            {
                propMethods testPrp = new propMethods();
                string currChoice = testPrp.getChoice(retChc);
                if (currChoice == null) Console.WriteLine("Invalid property");
                if (currChoice != null)
                {
                    Console.WriteLine(selPropQuestion + currChoice);
                    int propData = testPrp.getProperty(currChoice);
                    testPrp.dispProperty(propData);
                }
            }
            if (actionChc == 2)
            {
                askSetQuestion();

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            start startPrg = new start();
            startPrg.startProgram();
          
          



        }
    }
}
