using System;
using System.Collections.Generic;
using System.Linq;

namespace Finder
{
    class Program
    //USING LINQ Approach
    {
        public record Person(string name, string surname, int age);

        static void Main(string[] args)
        {
            var people = new List<Person>{
                new Person("Sophie", "Wilson", 63),
                new Person("Steve", "Wilson", 68),
                new Person("Chris", "Curry", 75)
            };
            var oldest = FindOldest(people);
            Console.WriteLine($"{oldest.name} is the oldest");
        }

        public static Person FindOldest(List<Person> people)
        {
            return (
                people.Find(p => p.age ==
                    people.Select(a => a.age).Max()
                ));
        }
    }
}
