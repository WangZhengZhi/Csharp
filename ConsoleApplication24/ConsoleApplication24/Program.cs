using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication24
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ArrayList类概述
            //ArrayList是一种高级的动态数组，它是Array类的升级版本，
           /*
            ArrayList arr=new ArrayList();//声明一个ArrayList对象
            for (int i = 0; i < 10; i++)
            {
                arr.Add(i);

            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            int[]arr1=new int[]{1,2,3,4,5,6,7,8,9};
            ArrayList arr2=new ArrayList(arr1);
            foreach (int num2 in arr2)
            {
                Console.WriteLine(num2);
            }
            */



            /*_____________________
            ArrayList arr=new ArrayList(10);//声明一个具有10个元素的ArrayList对象，并为其赋值；
            for (int i = 0; i < arr.Count; i++)
            {
                arr.Add(i);
            }//给ArrayList对象添加10个int元素；
_____________________________________________*/
            /*            ArrayList元素的添加        */
            /*                Add方法        */
            /*
            int[]arr=new int[]{1,2,3,4,5};
            ArrayList arr1=new ArrayList(arr);
            arr1.Add(7);
            foreach (int num in arr1)
            {
               Console.WriteLine(num);
            }
            */
            /*            Insert方法            */
            //Insert(int index,object value)
            /*
            int[]arr=new int[]{1,2,3,4};
            ArrayList arr1=new ArrayList(arr);
            arr1.Insert(3,7);
            foreach (int num in arr1)
            {
               Console.Write("  "+num);

            }
            */
            //练习
            /*
            int[]arr=new int[]{1,2,3,4,5};
            ArrayList arr1=new ArrayList(arr);
            arr1.Add(6);
            arr1.Insert(arr1.Count,7);//arr1.Count是元素的个数

            foreach (int num in arr1)
            {
                Console.Write("  "+num);

            }
            */
            /*            ArrayList元素的删除            */
            //Clear/Remove/RemoveAt/RemoveRange
            //1.Clear方法
            /*
            int[]arr=new int[]{1,2,3};
            ArrayList arr1=new ArrayList(arr);
            arr1.Clear();
            foreach (int num in arr)
            {
              Console.Write(num+"   ");
            }
            foreach (int num in arr1)
            {
              Console.Write(num+"  ");

            }
            */
            //2.Remove方法
            /*
            int[]arr=new int[]{1,2,3};
            ArrayList arr1=new ArrayList(arr);
            arr1.Remove(1);

            foreach (int num1 in arr1)
            {
                Console.Write(num1+"  ");
            }
            */
            //3.RemoveAt方法
            /*
            int[]arr=new int[]{1,2,3,4};
            ArrayList arr1=new ArrayList(arr);
            arr1.RemoveAt(3);//元素的索引index
            foreach (int num1 in arr1)
            {
               Console.WriteLine(num1);
            }
            */
            //RemoveRange(int index,int count)移除一定范围的元素
            /*
            int[]arr=new int[]{1,2,3,4,5,6};
            ArrayList arr1=new ArrayList(arr);
            arr1.RemoveRange(1,1);
            foreach (int num1 in arr1)
            {
                Console.Write(num1+"  ");

            }
            */
            //练习
            /*
            int[]arr=new int[]{1,2,3,4,5,6,7};
            ArrayList arr1=new ArrayList(arr);
            arr1.RemoveRange(0,4);
            foreach (int num1 in arr1)
            {
                Console.Write("  "+num1);

            }
            */
            //ArrayList的遍历
            /*
            ArrayList arr=new ArrayList();
            arr.Add("hello world");
            arr.Add("C#从入门到放弃");
            foreach (string str in arr)
            {
               Console.Write(str);
            }
            */
            //ArrayList元素的查找
            //Contains去查找某个元素是否在集合之中
            int[]arr=new int[]{1,2,3,4};
            ArrayList arr1=new ArrayList(arr);
            Console.Write(arr1.Contains(2));










        }
    }
}