////1. ArrayList
////- Là 1 mảng động
////- Cho phép lưu trữ các phần từ null và trùng nhau
////- Truy xuất phần tử thông qua chỉ số

//using System.Collections;

//ArrayList list = new ArrayList();


////- Thêm phần tử vào ArrayList
//list.Add("Phuc");
//list.Add('a');
//list.Add('a');
//list.Add(5);

////- truy xuất phần tử trong arraylist
//Console.WriteLine(list[0]);

////- chèn phần tử vào arraylist
//list.Insert(1, "Ngan");

////- xóa phàn tử trong arraylist
//list.Remove("Phuc"); // xóa theo giá trị
//list.RemoveAt(1); //xóa theo chỉ số

////- tìm kiếm
//Console.WriteLine(list.IndexOf('a'));  //trả về vị trí đầu tiền của 'a'
//Console.WriteLine(list.LastIndexOf('a'));   //trả về vị trí đầu tiền của 'a'

//Console.WriteLine("=========================================");

////- Duyệt các phần từ trong arraylist
//foreach (object item in list)
//{
//    Console.WriteLine(item);
//}


////================HashTable=====================
//2.Hashtable
//- Là 1 tập hợp các phần tử
//- Mỗi phần từ là 1 cặp <key, value>
//- key phải là duy nhất và khác null
//- Truy xuất phần tử thông qua key
//Hashtable ht = new Hashtable();

////- Thêm phần tử vào Hashtable
//ht.Add("Phuc", 10);
//ht.Add(7, "Ngan");
//ht.Add("Ngan", 100);

////- Xóa phần tử trong Hashtable
//ht.Remove("Ngan"); //xóa theo key

////- Truy xuất phần từ trong HashTable
//Console.WriteLine(ht[7]);

////- Duyệt các phần tử
////+C1: duyệt theo chiều dọc
//Console.WriteLine("=======duyet theo chieu doc============");
//ICollection keys = ht.Keys;
//foreach (object key in keys)
//{
//    Console.WriteLine($"{key}, {ht[key]}");
//}

////+C2: duyệt theo chiều ngang
//Console.WriteLine("=========duyet theo chieu ngang===========");
//foreach (DictionaryEntry entry in ht)
//{
//    Console.WriteLine($"{entry.Key}, {entry.Value}");
//}