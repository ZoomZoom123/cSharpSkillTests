using System;
 
 namespace LoopCounting
 {
     class Program
     {
         /* Count from 1 to 10
          * Then back to 1
          * Repeat five times
          * Do not use if statements
          */
         static void Main(string[] args)
         {
             var minNum = 1;
             var maxNum = 10;
             var repeater = 5;

             for (int j = 1; j <= repeater; j++)
             {
                 for (int i = minNum; i <= maxNum; i++)
                 {
                     Console.WriteLine(i);
                 }
                 for (int i = maxNum; i >= minNum; i--)
                 {
                     Console.WriteLine(i);
                 }
             }
         }
     }
 }