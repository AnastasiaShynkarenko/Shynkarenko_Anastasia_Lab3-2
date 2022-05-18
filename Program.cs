using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {


            var d1 = new Dictionary<string, int>()
            {
                ["a"] = 1,
                ["b"] = 2,
                ["c"] = 3,
            };
            foreach (KeyValuePair<string, int> letter in d1)
            {
                Console.WriteLine($" d1:  key: {letter.Key}  value: {letter.Value}");
                
            }
            Console.WriteLine("--------------------");
            var d2 = new Dictionary<string, int>()
            {
                ["a"] = 3,
                ["b"] = 2,
                ["d"] = 4,
            };
            foreach (KeyValuePair<string, int> letter in d2)
            {
                Console.WriteLine($" d2:  key: {letter.Key}  value: {letter.Value}");
               
            }
            Console.WriteLine("--------------------");

            var resDict = d1.Concat(d2).GroupBy(x => x.Key)
                   .ToDictionary(x => x.Key, x => x.Sum(y => y.Value));
            foreach (KeyValuePair<string, int> e in resDict)
                {
                    Console.WriteLine($" d1+d2:  key: {e.Key}  value: {e.Value}");
                }
         }

    }
}