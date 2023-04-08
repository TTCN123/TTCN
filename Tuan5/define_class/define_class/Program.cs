using System;

namespace define_class
{
    class Program
    {
        public class Student
        {
            public string FullName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
        }
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.FullName = "Nguyen Van A";
            student.Address = "123 Nguyen Trai, Quan 1, TP.HCM";
            student.Age = 20;
        }
    }
}