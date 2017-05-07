using System;
using System.Collections.Generic;

namespace ConsoleApplication16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //第七章数组
            //一维数组
            /*
            int[] arr = new int[5];//初始化。全为0；
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}",i,arr[i]);


            }
            foreach (int  n in arr)
            {
               Console.WriteLine(n);
            }
            */
            //二维数组
            /*int[,] arr=new int[,] {{2, 2}, {3, 4}};
            Console.WriteLine(arr.Rank);//获得数组的行数
            Console.WriteLine(arr.GetUpperBound(arr.Rank-1)+1);//获得数组的列数
            for (int i = 0; i < arr.Rank; i++)
            {
                string str = "";
                for (int j = 0;j < arr.GetUpperBound(arr.Rank - 1) + 1;j++)
                        {
                           Console.Write(arr[i,j]);

                        }
                Console.WriteLine("       ");



            }*/
            //动态二维数组的声明及使用
            /*int m=3;
            int n=4;
            int[,] str=new int[m,n];*/
            //数组的基本操作
            //遍历数组
            /*int[] arr = new int[] {1, 2, 3, 4, 5, 6};
            foreach (int i in arr)
            {
              Console.WriteLine(i);
            }
            int num = 1;
            for(int i=num;i<arr.Length-num;i++)
            {
                arr[i] = arr[i + 1];
            }
            foreach (int  i in arr)
            {
                Console.WriteLine(i);
            }*/
            //对数组进行排序
            //冒泡法
            int[] arr=new int[]{3,8,24,21,15};
            foreach (int  i in arr)
            {
              Console.WriteLine(i+"    ");

            }
            Console.WriteLine("__________________________");
            int j, temp;
            for (int i = 0; i < arr.Length-1; i++)
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
            foreach (int  num in arr)
            {
              Console.WriteLine(num);
            }












        }
    }
}