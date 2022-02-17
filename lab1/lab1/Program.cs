using System;

namespace MyApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(a, 1));
            //int[] a = new int[4] { 10, 2, 3, 3 };
            //Console.WriteLine(HW1.QueueTime(a, 2));
            //int[] a = new int[3] { 2, 3, 10 };
            //Console.WriteLine(HW1.QueueTime(a, 2));
        }
    }

    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            var place = new int[n];

            for (int i = 0; i < customers.Length; i++)
            {
                place[0] += customers[i];
                Array.Sort(place);
            }

            return place[n - 1];
        }
    }


}
