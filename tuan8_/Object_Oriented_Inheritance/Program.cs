using System;

namespace InheritanceExample
{
    // Lớp cha
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Lớp con kế thừa từ lớp cha
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng của lớp con
            Dog myDog = new Dog("Max", 5, "Golden Retriever");

            // Gọi các thuộc tính và phương thức của lớp cha
            Console.WriteLine(myDog.Name); // Output: Max
            Console.WriteLine(myDog.Age); // Output: 5

            myDog.Eat(); // Output: Eating...

            // Gọi các thuộc tính và phương thức của lớp con
            myDog.Bark(); // Output: Woof!
        }
    }
}
