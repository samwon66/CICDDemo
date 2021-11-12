using System;

namespace CICDDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome!");
            Hello();
        }

        private static void Hello()
        {
            Console.WriteLine("Testing my first workflow\n Add new text in branch dev."); 
        }
    }
}
