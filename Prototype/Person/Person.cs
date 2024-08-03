namespace Prototype.Person
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person Clone() => new Person(Name, Age);

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
