using System;

namespace Lab3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Множення двох двійкових чисел з зсувом першого множника ліворуч при кожному кроці");
            Console.WriteLine("\n\nВведіть перше число");
            string First = Console.ReadLine();
            Console.WriteLine("введіть друге число");
            string Second = Console.ReadLine();
            int First1 = Convert.ToInt32(First, 2);
            int Second2 = Convert.ToInt32(Second, 2);
            string zero_count = null;
            string space_count1 = " ";
            string space_count2 = " ";
            string string_num1 = null;
            string string_zero = null;
            for (int q = 0; q < First.Length; q++)
            {
                zero_count += 0;
            }
            for (int q = Second.Length; q > 0; q--)
            {
                space_count1 += ' ';
                space_count2 += ' ';
            }
            Console.WriteLine("\n\n" + space_count1 + First);
            Console.WriteLine(space_count1 + "x");
            Console.WriteLine(space_count2 + Second);
            Console.WriteLine("_____________");
            for (int i = Second.Length - 1; i >= 0; i--)
            {
                int p = Convert.ToInt32(Second[i]);
                space_count1 = space_count1.Remove(0, 1);
                space_count2 = space_count2.Remove(0, 1);
                string_zero += space_count2 + First;
                string_num1 += space_count1 + zero_count;
                if (p == 49)
                {
                    Console.WriteLine(string_zero);
                }
                else
                {
                    Console.WriteLine(string_num1);
                }
                string_zero = null;
                string_num1 = null;
            }
            int Sum = First1 * Second2;
            string Sum1 = Convert.ToString(Sum, 2);
            Console.WriteLine("_____________");
            Console.WriteLine(Sum1);
            Console.ReadKey();
        }
    }
}
