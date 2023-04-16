using System;

namespace SwitchAndIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            switch (num) 
            {
                case 1:
                    Console.WriteLine(@$"{num}是1；");
                    break;
                case 10:
                    Console.WriteLine($@"{num}是10");
                    break;
                default:
                    Console.WriteLine(@$"啥也不是");
                    break;
            }
        }
    }
}
