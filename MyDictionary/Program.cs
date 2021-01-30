using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> MyDictionary = new MyDictionary<string, int>();
            MyDictionary.Add("Episode One", 51);
            MyDictionary.Add("Episode Two", 57);
            MyDictionary.Add("Episode Three", 55);
            MyDictionary.Add("Episode Four", 58);
            MyDictionary.Add("Episode Five", 51);

            Console.WriteLine("Season One : " + MyDictionary.Keys[0] + "  Time: " + MyDictionary.Values[0]);
            Console.WriteLine("Season One : " + MyDictionary.Keys[1] + "  Time: " + MyDictionary.Values[1]);
            Console.WriteLine("Season One : " + MyDictionary.Keys[1] + "  Time: " + MyDictionary.Values[2]);
            Console.WriteLine("Season One : " + MyDictionary.Keys[1] + "  Time: " + MyDictionary.Values[3]);
            Console.WriteLine("Season One : " + MyDictionary.Keys[1] + "  Time: " + MyDictionary.Values[4]);

            Console.WriteLine("Total Episodes Number: " + MyDictionary.Values.Length);
        }
    }

}
