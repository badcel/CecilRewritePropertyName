using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var testObject = new TestLibrary.Label();
            testObject.Label = 5;

            Console.WriteLine(testObject.Label);
        }
    }
}