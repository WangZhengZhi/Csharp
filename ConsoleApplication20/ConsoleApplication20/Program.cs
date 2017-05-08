using System;
using System.Collections.Generic;

namespace ConsoleApplication20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*-------------------------------
            //直接插入法
            //从小到达排列
            int[]arr=new int[]{23,1,45,44,76,67};
            for (int i = 0; i < 6; i++)
            {
                int temp = arr[i];
                int j = i;
                while ((j > 0) && (arr[j - 1] > temp))//判断数组的元素是否大于获得的值
                {
                        //如果是，将后一个元素的值提前
                    arr[j] = arr[j - 1];
                    --j;

                }
                arr[j] = temp;//最后将int变量存储的值赋给最后一个元素


            }
            Console.WriteLine("最后排序之后的值为：");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            ----------------------------------*/
            int[]arr=new int[]{11,2,7,45,34,67,89,9090,78};
            for (int i = 0; i < 6; i++)
            {
                int temp = arr[i];
                int j = i;
                while ((j>0)&&(arr[j-1]>temp))
                {
                    arr[j] = arr[j - 1];
                    --j;

                }
                arr[j] = temp;
            }
            Console.WriteLine("排序之后的值为：");
            foreach (int i in arr)
            {
               Console.WriteLine(i);
            }




        }
    }
}