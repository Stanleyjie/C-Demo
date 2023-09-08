using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Begin--------");
            DateTimeDemo();
            Console.WriteLine("--------End--------");
        }
        /// <summary>
        /// String.IsNullOrEmpty and String.IsNullOrWhiteSpace
        /*.Net Framework 4.0 Beta 2 has a new IsNullOrWhiteSpace() method for strings 
         * which generalizes the IsNullOrEmpty() method to also include other white space besides empty string.
         * The term “white space” includes all characters that are not visible on screen.For example, space, 
         * line break, tab and empty string are white space characters*.*/
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

        public static void DateTimeDemo()
        {
            var now = DateTime.Now.Hour;
            Console.WriteLine(now);
        }
    }
}
