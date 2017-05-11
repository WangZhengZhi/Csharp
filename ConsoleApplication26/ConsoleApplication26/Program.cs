using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication26
{
    internal class Program
    {
        public static void Main(string[] args)
        {//哈希表（Hashtable）
            Hashtable hashtable=new Hashtable();
            hashtable.Add("id","15426037");
            hashtable.Add("name","wangzhengzhi");
            hashtable.Add("sex","BOY");
            hashtable.Add("nation","China");
            Console.WriteLine(hashtable.Count);//获取HASHTABLE中的元素的个数
            //Hashtable 的删除的方法
            //Clear()
            /*hashtable.Clear();//删除所有的元素
            Console.WriteLine(hashtable.Count);*/
            //Remove方法
            /*hashtable.Remove("sex");
            Console.WriteLine(hashtable.Count);*/
            //Hashtable 的遍历
            /*
            foreach (DictionaryEntry str in hashtable)
            {
              Console.WriteLine(str.Key+" "+str.Value);
            }
            */
            //Hashtable 元素的查找
            //Contains()方法||ContainsKey()查找元素的key
            Console.WriteLine(hashtable.Contains("nation"));

            //ContainsValue()查找元素的Value
            Console.WriteLine(hashtable.ContainsValue("China"));





        }
    }
}