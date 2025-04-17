static int TinhTong(int a, int b)
{
    return a + b;
}
static void LoiChao(string name)
{
    Console.WriteLine($"Xin chao: {name}");
}
//2. Khởi tạo
//TinhToan tt = TinhTong;
//HienThi ht = LoiChao;
//Func<int, int, int> tt = TinhTong;
//Action<string> ht = LoiChao;

//Có cách nào viết trực tiếp TinhTong không 
//--> Sử dụng Anonymous method (phương thức nặc danh)
//Func<int, int, int> tt = delegate (int a, int b)
//{
//    return a + b;
//};

//Biểu thức lambda: là cách viết rút gọn cúa phương thức nặc danh
//Func<int, int, int> tt = delegate (int a, int b){  return a + b;  };
//Func<int, int, int> tt = (int a, int b) => { return a + b; };
//Func<int, int, int> tt = (int a, int b) => a + b;
Func<int, int, int> tt = (a, b) => a + b;

//Action<string> ht = delegate (string name) { Console.WriteLine("Xin chao: " + name); };
Action<string> ht = (string name) => { Console.WriteLine("Xin chao: " + name); };

//3. Thực thi
int kq = tt(3, 4);
Console.WriteLine(kq);
//ht("Ngan");
//1. Khai báo delegate
//public delegate int TinhToan(int x, int y);
//public delegate void HienThi(string s);