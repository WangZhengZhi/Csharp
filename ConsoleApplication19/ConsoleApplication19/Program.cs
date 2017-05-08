using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace ConsoleApplication19
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //冒泡排序法v3.0
            //从小到大排列
           /* int[] arr=new int[]{1,89,3,88};
            int j;
            int temp;
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
                    if (j < arr.Length-1)
                    {
                        j++;
                        goto ID;
                    }

                }



            }
            foreach (int  i in arr)
            {
               Console.WriteLine(i+"           ");

            }*/
            /*________冒泡排序法V4.0______________*/
            int[]arr=new int[]{34,12,99,89,80};
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
            foreach (int  i in arr)
            {
                Console.WriteLine(i);

            }




        }
    }
}