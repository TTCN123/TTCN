using System;

namespace _tuan5
{
    class Exception
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập một số nguyên: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Số vừa nhập là: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            Console.WriteLine("Chương trình đã kết thúc.");
            Console.ReadLine();
        }
    }
}