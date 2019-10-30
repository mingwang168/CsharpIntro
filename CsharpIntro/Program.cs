using System;

namespace CsharpIntro
{
    class Program
    {
        // private const string MESSAGE = "Hello World";
        public string MyName = "Phil";
        static void Main(string[] args)
        {
            string message="Hello World";
            int myAge = 39;
            byte myByte = 7;
            double myDouble = 10.456;
            decimal myDecimal = 10.456m;
            float myFloat = 10.456f;
            bool myBool = false;
            DateTime currentDate = DateTime.UtcNow;
            Console.WriteLine(myBool.ToString()+"is the value of myBool!");
            DateTime currenDate = DateTime.UtcNow;
            Console.WriteLine(GetIntSum(5,7));
            Console.ReadLine();

        }

        private static int GetIntSum(int a,int b)
        {
            return a + b;
        }
    }
}
