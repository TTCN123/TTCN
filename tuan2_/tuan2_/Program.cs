using System;

namespace Methods
{
    class Program
    {

        public static void Input_output()
        {

          /* Nhập kiểu số nguyên*/
            Console.Write("Hãy nhập số lượng sản phẩm: ");
            int soLuong = int.Parse(Console.ReadLine());

            /*nhập kiểu số thực*/

            Console.Write("Hãy nhập tỷ lệ phần trăm giảm giá: ");
            float tyLeGiamGia = float.Parse(Console.ReadLine());

           /* nhập kiểu chuỗi */

            Console.Write("Hãy nhập tên của bạn: ");
            string ten = Console.ReadLine();

           /* nhập kiểu bool*/

            Console.Write("Hãy nhập trạng thái hoạt động (true hoặc false): ");
            bool trangThai = bool.Parse(Console.ReadLine());
        }


        public static void conditional_statements()
        {
            int weight = 700;
            Console.WriteLine(weight >= 500); // True
            char gender = 'm';
            Console.WriteLine(gender <= 'f'); // False
            double colorWaveLength = 1.630;
            Console.WriteLine(colorWaveLength > 1.621); // True
            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition); // True
            Console.WriteLine('B' == 'A' + 1);
        }
        public static void loops()
        {
            // Initialize the counter
            int counter = 0;
            // Execute the loop body while the loop condition holds
            while (counter <= 9)
            {
                // Print the counter value
                Console.WriteLine("Number : " + counter);
                // Increment the counter
                counter++;
            }

        }
        public static void Arr()
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("For loops: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index " + i + ": " + numbers[i]);
            }

            Console.WriteLine("Foreach: ");
            Console.WriteLine("Array Elements: ");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Nhập xuât: ");
            Input_output();
            System.Console.WriteLine("Câu điều kiện: ");
            conditional_statements();
            System.Console.WriteLine("Vòng lặp: ");
            loops();
            System.Console.WriteLine("Mảng: ");

            Arr();
        }
    }
}

    