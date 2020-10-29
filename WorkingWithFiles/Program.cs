using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\...\source\repos\test.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from file: {line}");
            }

            dataFromFile.Add("grapes");
            File.WriteAllLines(filePath, dataFromFile);
            /*
             1. Create a new WishList project
             2. In data folder, create a new wishlist.txt file
             3. Let the user to enter three wishes into the console
             4. Save the users wishes to a list wishes
             5. Save the wishes list to the wishlist.txt file
             */
        }
    }
}
