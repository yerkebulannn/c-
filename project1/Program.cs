using System;
using System.Xml.XPath;

namespace project1{
    class Program{
        static void Main(){
            int  user_input;
            user_input = int.Parse(Console.ReadLine());
            int result = user_input + 5;

            Console.WriteLine("variable is " + result);
        }
    }
}