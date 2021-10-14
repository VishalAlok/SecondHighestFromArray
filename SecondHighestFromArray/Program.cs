using System;

namespace SecondHighestFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[] { 5, 8, 11, 34, 23 };

            int largest = int.MinValue;
            int second = int.MinValue;

            foreach (int i in MyArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }
            System.Console.WriteLine(second);
        }
    }
}
