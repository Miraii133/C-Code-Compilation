using System;

namespace PrivateMethodsPractice
{
    public class method {

        private string name = "Jiyo";
        private void sayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void getHe()
        {
            sayHello(name);
        }
       
    }

    public class say
    {
        public void getHello()
        {
            method method = new method();
            method.getHe();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            say sa = new say();
            sa.getHello();
        }
    }
}
