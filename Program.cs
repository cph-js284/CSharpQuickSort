using System;

namespace CSharpQuickSort
{
    class Program
    {
        static void printArr(int[] arr){
            foreach (var item in arr)
            {
                System.Console.Write($"[{item}] ");
            }
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] testArr = new int[20];
            for (int i = 0; i < testArr.Length; i++)
            {
                testArr[i]=rng.Next(1,100);
            }
            System.Console.WriteLine("- - - BEFORE - - -");
            printArr(testArr);

            Qsort QS = new Qsort();
            QS.QuickSort(testArr, 0 , testArr.Length-1);

            System.Console.WriteLine("\n- - - AFTER - - -");

            printArr(testArr);
        }
    }
}
