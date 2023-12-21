using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    internal class Program1Aggr_Operators
    {
        //static void Main(string[] args)
        //{
        //    List<Person> listPersonsInCity = new List<Person>();

        //    listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
        //    listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
        //    listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
        //    listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
        //    listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
        //    listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
        //    listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
        //    listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
        //    listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));
        //    Console.WriteLine("\n-------------------learn Lambda Expression  with Various methods ---------");
        //    Console.WriteLine(" Retrieving  persons from the list who are older than 60 years\n");
        //    foreach(Person person in listPersonsInCity.FindAll(p=>p.Age>60).Take(2))
        //    {
        //        Console.WriteLine(person.Name+ "  Age:" + person.Age  );

        //    }
        //    var aboveTen=listPersonsInCity.All(p=>p.Age>10);
        //    Console.WriteLine("Is every person in the list above age 10 ?"+aboveTen);
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine("\n Checking the index position of a person having name 'Smith' ...");
        //    int indexForSmith = listPersonsInCity.FindIndex(e => e.Name == "Smith");
        //    Console.WriteLine(" In the list, The index position of a person having name 'Smith' is : " + indexForSmith);
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine("\n Getting the name of the most aged person in the list ...");
        //    Person p = listPersonsInCity.First(m => m.Age == (listPersonsInCity.Max(e => e.Age)));
        //    Console.WriteLine(" The most aged person in our list is: " + p.Name + " whose age is: " + p.Age);
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine("\n Skipping every person whose age is less than 65 years...");
        //    foreach (Person pers in listPersonsInCity.SkipWhile(e=>e.Age<65))
        //    {
        //        Console.WriteLine(" Name : " + pers.Name + " \t\tAge: " + pers.Age);
        //    }
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");
        //    Console.WriteLine(" Displaying the persons until we find a person with name starts with other than 'J'");
        //    foreach (Person pers in listPersonsInCity.TakeWhile(e => e.Name.StartsWith("J")))
        //    {
        //        Console.WriteLine(" Name : " + pers.Name + " \t\tAge: " + pers.Age);
        //    }
        //    Console.WriteLine("\n-----------------------------------------------------------------------------");

        //    Console.WriteLine("count of persons =" + listPersonsInCity.Count()); 
        //    Console.WriteLine("\n Removing all the persons record from list that have “SAM” name");
        //    listPersonsInCity.RemoveAll(e => (e.Name == "SAM"));
        //    if (listPersonsInCity.TrueForAll(e => e.Name != "SAM"))
        //    {
        //        Console.WriteLine(" No person is found with 'SAM' name in current list");
        //    }
        //    Console.WriteLine( "count of persons ="+listPersonsInCity.Count() );
        //}
    }
}
