// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace HelloWorld.DemoLists
{
    public class DemoLists
    {
        void Test()
        {
            // Lists - dynamic size
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 1: ", numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: ", numbers.LastIndexOf(1));
            Console.WriteLine("Count: ", numbers.Count);

            numbers.Remove(1);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
