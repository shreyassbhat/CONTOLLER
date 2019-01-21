using System;

namespace Stringss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateFile();
            Console.ReadKey();
            
        }

        private static void CreateFile()
        {
            Console.WriteLine("This is from private class");
            // String var = Console.ReadLine();
            //String var1 = Console.ReadLine();
            //String var2 = Console.ReadLine();
            Console.WriteLine("Enter the no of string");
            String n = Console.ReadLine();
            string[] answer = new string[Convert.ToInt32(n)];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Console.ReadLine();
            }

           //w for (int i=0; i<answer.Length; i++)
            //{
                System.IO.File.WriteAllLines(@"C:\Users\Shreyas\Desktop\file.txt", answer);
            //}
            
        }

    }
}
