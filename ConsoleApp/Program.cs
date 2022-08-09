using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Begin--------");
            StringIsNull();
            Console.WriteLine("--------End--------");
        }
        /// <summary>
        /// String.IsNullOrEmpty and String.IsNullOrWhiteSpace
        /// </summary>
        public static void StringIsNull() 
        {
            string nullString = null;
            string emptyString = "";
            string whiteSpaceString = "   ";
            string nonEmptyString = "abc123";
            bool result;
            Console.WriteLine(String.IsNullOrEmpty(nullString));                    //true
            Console.WriteLine(String.IsNullOrEmpty(emptyString));                   //true
            Console.WriteLine(String.IsNullOrEmpty(whiteSpaceString));              //false
            Console.WriteLine(String.IsNullOrEmpty(nonEmptyString));                //false
            Console.WriteLine(String.IsNullOrWhiteSpace(nullString));               //true
            Console.WriteLine(String.IsNullOrWhiteSpace(emptyString));              //true
            Console.WriteLine(String.IsNullOrWhiteSpace(whiteSpaceString));         //true
            Console.WriteLine(String.IsNullOrWhiteSpace(nonEmptyString));           //false
        }
    }
}
