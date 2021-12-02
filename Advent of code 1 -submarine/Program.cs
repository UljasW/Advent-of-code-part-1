using System;

namespace Advent_of_code_1__submarine
{
    class Program
    {
        public static string[] lines;
        public static int[] linesAsInt;
        public static int activeNum, lastNum = 0, increases, decreases, equal, total = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            
            lines = System.IO.File.ReadAllLines(@"\\fs1.ad.ssis.nu\21ulwe\Desktop\Vscode repos\Advent of code\Advent of code 1 -submarine\MyInput.txt");
            
            foreach (string line in lines)
            {
                linesAsInt = Array.ConvertAll(line.Split(' '), int.Parse);
                activeNum = linesAsInt[0];
                if (activeNum > lastNum)
                {
                    increases++;
                }
                else if (activeNum < lastNum)
                {
                    decreases++;
                }
                else
                {
                    equal++;
                }
                lastNum = activeNum;
                total++;
                
            }

            System.Console.WriteLine("The number of times the value has increased is: " + increases);
            System.Console.WriteLine("The number of times the value has decreased is: " + decreases);
            System.Console.WriteLine("The number of times the value has not changed is: " + equal);
            System.Console.WriteLine("The total number of values is: " + total);
            Console.ReadKey();
        }
    }
    class solveNoice
    {
        
    }
}
