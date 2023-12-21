using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    internal class Program3SkipWhile_TakeWhile
    {
      //public static void Main()
       // {// TakeWhile()
            //List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 }; // Will contain { 1, 2, 4 } 
            //IEnumerable<int> result = ints.TakeWhile(theInt => theInt < 5);
            ////It starts taking numbers from beginning because it fullfills the condition <5
            //// as soon as the condition fails at number 8 it stops even checking next numbers 
            //// even though they fullfill the condition
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // SkipWhile()
            //List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            //// Will contain { 4, 8, 4, 2, 1 } 
            //IEnumerable<int> result = ints.SkipWhile(theInt => theInt != 4);
            //It starts skipping from beginning because it fullfills the condition !=4 
            // as soon as the condition fails at 3rd position 4 , it continues to take all next elements 
            // because skip is opposite to take 
        //    foreach (int i in result)
        //    {
        //        Console.WriteLine(i);
        //    }


        //}
    }
}
