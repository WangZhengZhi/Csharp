using System;
using System.Collections.Generic;

namespace ConsoleApplication17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //冒泡排序法
            int[] arr=new int[]{8,84,56,9,78};
            int j, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                j = i + 1;
                ID:
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    goto ID;
                }
                else
                {
                    if (j < arr.Length - 1)
                    {
                        j++;
                        goto ID;
                    }

                }
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

        }
    }
}