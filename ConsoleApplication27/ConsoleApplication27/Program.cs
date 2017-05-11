using System;
using System.Collections.Generic;

namespace ConsoleApplication27
{
    internal class Program
    {
        public static void Main(string[] args)
        {//希尔排序法对定义的一维数组进行排序
        //插入排序法
        int[]arr=new int[]{11,45,23,56};
        for(int i=0;i<arr.Length;i++)
        {
            int temp=arr[i];
            int j=i;
            while((j>0)&&(arr[j-1]>temp))
            {
                arr[j]=arr[j-1];
                --j;
            }
            arr[j]=temp;

        }
        foreach(int num in arr)
        {
            Console.WriteLine(num+" ");

        }


        }
        
    }
}