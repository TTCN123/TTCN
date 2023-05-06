using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khởi tạo một HashSet kiểu Person
        HashSet<Person> people = new HashSet<Person>();

        // Tạo một số đối tượng Person
        Person person1 = new Person("John", "Doe");
        Person person2 = new Person("Jane", "Doe");
        Person person3 = new Person("Bob", "Smith");

        // Thêm các đối tượng vào HashSet
        people.Add(person1);
        people.Add(person2);
        people.Add(person3);

        // Hiển thị số lượng đối tượng trong HashSet
        Console.WriteLine("Số lượng đối tượng trong HashSet: {0}", people.Count);

        // Tìm kiếm một đối tượng trong HashSet
        if (people.Contains(person1))
        {
            Console.WriteLine("HashSet chứa đối tượng Person: {0} {1}", person1.FirstName, person1.LastName);
        }
        else
        {
            Console.WriteLine("HashSet không chứa đối tượng Person: {0} {1}", person1.FirstName, person1.LastName);
        }

        // Xóa một đối tượng khỏi HashSet
        people.Remove(person2);

        // Hiển thị lại số lượng đối tượng trong HashSet
        Console.WriteLine("Sau khi xóa một đối tượng, số lượng đối tượng trong HashSet: {0}", people.Count);
    }
}

class Person : IEquatable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public bool Equals(Person other)
    {
        if (other == null) return false;
        return (this.FirstName.Equals(other.FirstName) && this.LastName.Equals(other.LastName));
    }

    public override int GetHashCode()
    {
        return (FirstName + LastName).GetHashCode();
    }
}
