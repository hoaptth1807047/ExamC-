using System;
using System.Text.RegularExpressions;

namespace ExamCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1: \n");
//            1
            var people = new People("Marry", true, 25);
            Console.WriteLine("Person detail: ");
            Console.WriteLine(
                people.Gender ? "Name = {0}, Gender = Male, Age = {1}" : "Name = {0}, Gender = Female, Age = {1}",
                people.Name, people.Age);
            people.Age += 10;
            Console.WriteLine("Person detail (apter incrementing age): ");
            Console.WriteLine(
                people.Gender ? "Name = {0}, Gender = Male, Age = {1}" : "Name = {0}, Gender = Female, Age = {1}",
                people.Name, people.Age);
            Console.WriteLine("\n");
            
//            2
            Console.WriteLine("Exercise 2: \n");
            Console.WriteLine("Enter the string: ");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word search: ");
            var search = Console.ReadLine();
            var count = Regex.Matches(str, search).Count;
            Console.WriteLine("Word found {0} times in the string.", count);
        }
    }
}