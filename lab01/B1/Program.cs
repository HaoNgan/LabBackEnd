using System;
using System.Text;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cấu hình để hiển thị được tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Khai báo biến
            string ten;
            int tuoi;

            // 2. Nhập dữ liệu từ bàn phím
            Console.Write("Nhập tên của bạn: ");
            ten = Console.ReadLine();

            Console.Write("Nhập tuổi của bạn: ");
            tuoi = int.Parse(Console.ReadLine());

            // 3. Hiển thị câu chào
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
        }
    }
}
