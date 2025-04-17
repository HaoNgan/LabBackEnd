//1. List<T>: tương tự như ArrayList, nhưng phải xác định kiểu dữ liệu trước cho các phần tử

//List<string> list = new List<string>();
//list.Add("Ngan");
//list.Add("Phuc");
//list.Add("Haha");
//Có thể viết ngắn gọn như sau

List<string> list = new List<string>()
{
    "Ngan", "Phuc", "Ngenn"
};

//List<KhachHang> listKH = new List<KhachHang>();
//listKH.Add(new KhachHang() { MaKH = 1, TenKH = "Ngan" });
//listKH.Add(new KhachHang() { MaKH = 2, TenKH = "Phuc" });

//có thể viết ngắn gọn hơn
//List<KhachHang> listKH = new List<KhachHang>()
//{
//    new KhachHang() { MaKH = 1, TenKH = "Ngan" },
//    new KhachHang() { MaKH = 1, TenKH = "Phuc" }
//};

//Các phương thức thì tương tự như Arraylist

//2. Dictionary<K, V>: tương tự như Hashtable, nhưng K và V cần xác định kiểu dữ liêu trước
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "nn");
dict.Add(3, "hh");