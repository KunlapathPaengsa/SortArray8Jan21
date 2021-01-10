using System;

namespace SortArray8Jan21
{
    class Program
    {
        /* static void Main(string[] args)
         {
             int[] arr = new int[] {1,6,4,9,8,2,3};
             Console.WriteLine(arr);
             Array.Sort<int>(arr, new Comparison<int>(
                 (i1, i2) => i2.CompareTo(i1)));

             foreach(int value in arr)
             {
                 Console.Write(value + " ");
             }
         }
     }
 }*/

        static void Main(string[] args)
        {
            double avr = 0;
            double sum = 0;
            double max;
            double min;
            Console.WriteLine("how many numbers?");
            int b = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[b];
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < b; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
                if (arr[i] >= max)
                {
                    max = arr[i];
                }

                else if (arr[i] <= min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }

            sum = sum - max - min;
            avr = sum / (b - 2);

            Console.WriteLine("sum = {0},average = {1}, max = {2}, min = {3}", sum, avr, max, min);
            Console.ReadKey();
        }
    }
    
}