using System;
using System.Collections.Generic;

namespace ConsoleApplication22
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //array类的Sort和Reverse排序方法
            /*       int[]arr=new int[]{21,1,34,33,89,100};
            Array.Sort(arr);//从小到大排序
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            Array.Reverse(arr);//从大到小排序
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }            */
            //数组的合并和拆分
            //1.数组的合并
            int[]arr1=new int[]{1,2,3};
            int[]arr2=new int[]{4,5,6};
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
                    arr[i] = arr2[i - arr1.Length];

                }//合并为一维数组

            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            //合并为二维数组
            int[,]arr4=new int[2,5];
            for (int i = 0; i < arr4.Rank; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            arr4[i, j] = arr1[j];

                        }
                        break;
                    case 1:
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            arr4[i, j] = arr2[j];
                        }
                        break;


                }

            }
            for (int i = 0;i < arr4.Rank ;i++)
                    {
                        for (int j = 0; j < arr4.GetUpperBound(arr4.Rank - 1) + 1; j++)
                        {
                            Console.Write(arr4[i,j]+" ");

                        }
                        Console.WriteLine();

                    }



        }
    }
}