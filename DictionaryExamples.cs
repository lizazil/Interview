using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 2, 4, 4, 3 };
            int count = 0;

            //Find unique numbers
            int[] myArray = new int[10];
            int[] uniqueValues = new int[10];
            int k = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                }
                if (count==1)
                {
                    uniqueValues[k] = numbers[i];
                    k++;
                }
            }

            foreach (var val in uniqueValues)
            {
                if (val!=0)
                    Console.WriteLine(val);
            }


            // Find unique numbers using Dictionary
            Dictionary<int, int> uniqueList = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                if (uniqueList.ContainsKey(numbers[i]))
                {
                    uniqueList.TryGetValue(numbers[i], out count);
                    count++;
                    uniqueList[numbers[i]] = count;
                }
                else
                {
                    count++;
                    uniqueList.Add(numbers[i], count);
                }                
            }

            foreach (var u in uniqueList)
            {
                if (u.Value == 1)
                {
                    Console.WriteLine("Key {0}, Value {1}", u.Key, u.Value);
                }             
            }

            // Find distinct numbers using HashSet
            var uniqueSet = new HashSet<int>(numbers);

            foreach (var val in uniqueSet)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
