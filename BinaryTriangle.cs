using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class BinaryTriangle
    {
        public static void Main(String[] args)
        {
         // variables
            int p, lastInt = 0, input;
         // get the number of rows
            Console.WriteLine("Enter the Number of Rows : ");
         // read input
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                     // print item
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                } Console.Write("\n");
            }
            Console.ReadLine();
        } 
    } // end of program 
