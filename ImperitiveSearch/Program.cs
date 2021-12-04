using System;
using System.Collections.Generic;
using System.Linq;

namespace ImperitiveSearch
{
    class Program
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
            Console.WriteLine($"{oldest} is the oldest");
        }
        public static int FindOldest(List<Person> people)
        {
            var age = 0;
            foreach(var person in people)
                if(person.age > age)
                    age = person.age;

            return age;
        }
    }
}
