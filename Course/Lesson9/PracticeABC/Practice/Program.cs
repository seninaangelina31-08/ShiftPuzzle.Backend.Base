namespace Practice
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Привет, мое имя {name}");
            Console.WriteLine($"Мне {age} лет");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("Андрей", 20),
                new Person("Акшин", 23),
                new Person("Миша", 55)
            };

            foreach (var person in people)
            {
                person.Introduce();
            }
        }
    }
}