using System;
using System.Linq;

namespace LINQ_Example
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 100, 22, 3, 44, 50, 16, 37, 48, 19, 10, 11, 56 };
        //    string[] Names = { "Asha", "Lata", "Kishor", "Anup", "Meena" };
        //    string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        //    var result1=from n in numbers 
        //                where n%2!=0 
        //                select n;
            //Console.WriteLine("Given Array with odd numbers only ");
            //foreach (var n in result1) { Console.Write (n+ ","); }
            //Console.WriteLine(  "Names of Musicians ");
            //var result2=from musician in Names
            //            select musician;
            //foreach(string s in result2) { Console.Write(s + " ,"); }
            //Console.WriteLine("....................................................");
            //var result3= (from d in digits
            //             where d[1]=='i'
            //             select d).Reverse();
            //Console.WriteLine( "digits with second letter i" );
            //foreach(string s in result3)
           // Console.WriteLine(s);
    //        int[] ArrayA = { 1, 2, 10, 9, 7, 8, 77, 35 };
    //        int[] ArrayB = { 10, 5,2, 6, 7, 81,8, 1, 11, 100 };
    //        var result4=ArrayA.Union(ArrayB);
    //        Console.WriteLine( ".................................................");
    //        Console.WriteLine("Union of 2 arrays ");
    //        foreach(int a in result4)
    //            Console.Write(a+" ,");
    //        Console.WriteLine("\n...................Intersect of Arrays is.......................");
    //        var intersect = ArrayA.Intersect(ArrayB);
    //        foreach(int a in intersect)
    //        {
    //            Console.Write(a+",");
    //        }
    //        Console.WriteLine("aggregate function on numbers Array");

    //        Console.WriteLine("\n Sum = "+numbers.Sum()+"\n Count = "+numbers.Count()+"\n Max= "+numbers.Max());
    //        string[] words = { "believe", "relief", "receipt", "field" };

    //        var EafterI = words.Any(w => w.Contains("ie"));
    //        var IafterE = words.Any(w => w.Contains("ei"));
    //        // any  keyword stands for or OR operator  
    //        // in above expression even only single word contains e after i then o/p true 
    //        //Console.WriteLine(" E after I  answer is   " +EafterI);

    //        //Console.WriteLine(" I after E  answer is   " + IafterE);
    //        // All keyword stands for AND operator 
    //         EafterI = words.All(w => w.Contains("ie"));
    //        Console.WriteLine(" Is there every word having E after I ? " + EafterI);
    //        IafterE = words.All(w => w.Contains("ei"));
    //                    Console.WriteLine(" Is there every word having I after E ? "+IafterE);
    //        Console.ReadKey();
    //    }
    }
}
