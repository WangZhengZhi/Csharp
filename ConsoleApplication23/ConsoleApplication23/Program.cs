using System;
using System.Collections.Generic;

namespace ConsoleApplication23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //数组的拆分
            int[,]arr=new int[,]{{1,2,3},{4,5,6}};
            int[]arr1=new int[3];
            int[]arr2=new int[3];
            for (int i = 0; i < arr.Rank; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(arr.Rank - 1) + 1; j++)
                {
                    switch (i)
                    {
                        case 0: arr1[j] = arr[i, j];
                            break;
                        case 1: arr2[j] = arr[i, j];
                            break;


                    }

                }

            }
            foreach (int num1 in arr1)
            {
                Console.Write(num1+" ");

            }
            Console.WriteLine("_______");
            foreach (int num2 in arr2)
            {
                Console.Write(num2+" ");

            }

            /*Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.GetUpperBound(arr.Rank-1)+1);*/






        }
    }
}