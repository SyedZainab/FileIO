using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"test.txt";
            string[] ArrayLines;
            int n, i;

            Console.Write("Create a file and write an array of strings  :\n\n");
            
            //If the file already exists, delete it.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write("Input number of lines to write in the file: ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrayLines = new string[n];
            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrayLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrayLines);

            //Defining the stream reader
            using (StreamReader sr = File.OpenText(fileName))
            {
                string str = "";
                Console.Write("\n The content of the file is:\n", n);
                
                //Reading each line of the string
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", str);
                }
                Console.WriteLine();
            }
        }
    }
}
