using System;
using System.Collections.Generic;

namespace ConsoleApplication25
{
    internal class Program
    {
        public static void Main(string[] args)
        {//将两个一维数组合并为一个一维数组
            /*
            int[] arr1=new int[]{1,2,3,4,5};
            int[] arr2 = new int[] { 6,7,8,9};
            int n = arr1.Length + arr2.Length;
            int[]arr=new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr1.Length)
                {
                    arr[i] = arr1[i];

                }
                else
                {
                    arr[i] = arr2[i-arr1.Length];

                }

            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            */
            //将两个一维数组合并为一个二维的数组
            /*
            int[] arr1 = new int[] { 1,2,3};
            int[] arr2 = new int[] { 4,5,6};
            int[,]arr=new int[3,3];
            for (int i = 0; i < arr.Rank; i++)
            {
                switch (i)
                {
                    case 0:
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            arr[i, j] = arr1[j];
                        }

                    }
                        break;
                    case 1:
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            arr[i, j] = arr2[j];
                        }

                    }
                        break;

                }

            }
            for (int i = 0; i < arr.Rank; i++)
            {
                for (int j = 0; j < (arr.GetUpperBound(arr.Rank - 1) + 1); j++)
                {
                    Console.Write(arr[i,j]+" ");

                }
                Console.WriteLine();

            }*/
            //数组的拆分
            /*
            int[,]arr=new int[,]{{1,2,3},{4,5,6}};
            int[]arr1=new int[3];
            int[]arr2=new int[3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
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
            Console.WriteLine();
            foreach (int num2 in arr2)
            {
               Console.Write(num2+" ");

            }
            */





        }
    }
}