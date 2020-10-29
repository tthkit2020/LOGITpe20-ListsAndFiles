using System;
using System.Collections.Generic;
using System.IO;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishes = new List<string>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("What do you wish for?");
                wishes.Add(Console.ReadLine());
            }

            string filePath = @"C:\Users\julia.voronetskaja\data\wishList.txt";
            File.WriteAllLines(filePath, wishes);

        }
    }
}
