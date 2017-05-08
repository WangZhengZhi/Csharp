using System;
using System.Collections.Generic;

namespace ConsoleApplication21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //选择排序法对数组进行从小到大的排列顺序
            // 暂时没看明白。回来在看
            int[]arr=new int[]{99,76,100,109,87,88};
            int min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;

                    }

                }
                int t = arr[min];
                arr[min] = arr[i];
                arr[i] = t;

            }
            Console.WriteLine("排序之后的结果为：");
            foreach (int  num in arr)
            {
               Console.WriteLine(num);

            }


        }
    }
}