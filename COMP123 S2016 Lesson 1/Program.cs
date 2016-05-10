using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //call HellowWorld Method
            HelloWorldToConsole();
        }
        //Description: This is my Hello,World! String
        //Method:Hello World to Console
        //return HellowWorldString
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
