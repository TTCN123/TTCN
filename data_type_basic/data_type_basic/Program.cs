using System;
using System.Drawing;

namespace Method
{
    class Program
    {
        public static void integerTypes()
        {
            int a = 10;         // kiểu số nguyên có dấu 32-bit
            uint b = 20;        // kiểu số nguyên không dấu 32-bit
            long c = 1000000L;  // kiểu số nguyên có dấu 64-bit
            ulong d = 2000000UL; // kiểu số nguyên không dấu 64-bit
            byte e = 255;       // kiểu số nguyên không dấu 8-bit
            sbyte f = -128;     // kiểu số nguyên có dấu 8-bit
            short g = -32000;   // kiểu số nguyên có dấu 16-bit
            ushort h = 65000;   // kiểu số nguyên không dấu 16-bit
        }
        public static void FloatingPointTypes() 
        {
            float a1 = 3.14159f;    // kiểu số thực đơn chính xác độ lớn khoảng ±1.5 x 10^-45 đến ±3.4 x 10^38
            double b1 = 3.1415926;  // kiểu số thực đôi chính xác độ lớn khoảng ±5.0 x 10^-324 đến ±1.7 x 10^308
            decimal c1 = 3.1415926535897932384626433833M; // kiểu số thực với độ chính xác cao, phù hợp cho tiền tệ và tài chính

        }
        public static void Character_string_types()
        {
            char a = 'A';                   // kiểu ký tự Unicode 16-bit
            string b = "Hello, world!";     // kiểu xâu

        }
        public static void Bool()
        {
            bool a = true;          // kiểu logic, chỉ có giá trị true hoặc false
        }
        public static void Datetime()
        {
            DateTime a = DateTime.Now;   // kiểu thời gian, lưu trữ ngày giờ hiện tại

        }
        public static void Object()
        {
            object a = "Hello, world!";   // kiểu đối tượng, có thể lưu trữ bất kỳ kiểu dữ liệu nào

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world");
        }
    }
}

