using System;
using System.Collections.Generic;

namespace CodeWarsTasks
{
    //https://www.codewars.com/kata/5263c6999e0f40dee200059d/train/csharp
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = GetPINs("123");
        }

        public static List<string> GetPINs(string observed)
        {
            Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>> {
                {1, new List<int>{1,2,4} }, {2, new List<int>{1,2,3,5}  },  {3, new List<int>{2,3,6} },
                {4, new List<int>{1,4,5,7}},{5, new List<int>{2,4,5,6,8} }, {6, new List<int>{3,5,6,9} },
                {7, new List<int>{4,7,8} }, {8, new List<int>{5,7,8,9,0} }, {9, new List<int>{6,8,9} },
                {0, new List<int>{8,0} }
            };

            foreach (var item in numbers)
            {
                foreach (var subItem in item.Value)
                {
                    Console.WriteLine($"{item.Key}\t-\t{subItem}");
                }
                Console.WriteLine("==========");
            }
            return null;
        }
    }
}