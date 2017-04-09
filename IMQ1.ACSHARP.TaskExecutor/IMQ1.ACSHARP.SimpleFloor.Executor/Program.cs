using System;

namespace IMQ1.ACSHARP.SimpleFloor.Executor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Result: Math.Floor( 2/1 + 3/2 + 5/3 + 7/4) = Math.Floor(6.916666666666667) = 6");
            Console.WriteLine("Program result = {0}", Simple.SimpleFloor.GetFloorOfSimpleNumbers(4));
            Console.ReadKey();
        }
    }
}
