using System;
using LanguageExt; 

namespace FoldSearch
{
    public partial class Age
    {
        public readonly int value;
    }
    class Program
    {
        public record Person(string name, string surname, int age);

        static void Main(string[] args)
        {
            var people = Seq(new Person("Sophie", "Wilson", 63),
                new Person("Steve", "Wilson", 68),
                new Person("Chris", "Curry", 75));

            var oldest = Program.FindOldestPerson(people);
            Console.WriteLine($"{oldest.name} is the oldest");
        }

        public static Person FindOldestPerson(Person personA, Person personB) => 
            personA.Age > personB.Age
            ? personA
            : personB;

        public static Option<Person>FindOldestPerson(Seq<Person> people) => 
            people.Fold(Option<Person>.None, 
                (optional Person, person) =>
                    optionalPerson.Fold(person, FindoldestPerson));

        public static Option<Age> FindoldestAge(Seq<Person> people) =>
            FindoldestPerson(people)
                .Map(person => person.Age);
    }
}
