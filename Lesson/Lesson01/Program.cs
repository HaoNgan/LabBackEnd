////Comment trên một dòng nè

///*
// Comment trên nhiều dòng nè
// */

////1. Khai báo biến
////Cú pháp: kiểu-dữ-liệu tên-biến = giá-trị;
//int a = 3;                  //Khai báo biến kiểu số nguyên
//float b = 4.444444f;        //Khai báo biến kiểu số thực
//double c = 5.5555;          //Số thực (không cần đuôi float)
//char d = 'd';               //Kí tự
//string e = "Hello World";   //String
//bool f = true;              //Đúng sai

////2. Nhập, xuất dữ liệu
//string name = "Phúc";
//Console.Write(name);        //Hiển trị dữ liệu
//Console.WriteLine("Name: " + name);        //Hiển thị dữ liệu và xuống dòng
//Console.WriteLine($"Name: {name}");

//Console.Write("Nhập tên của bạn: ");
//name = Console.ReadLine();

//Console.Write("Nhập tuổi của bạn: ");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"Name: {name}, age: {age}");

////3. Cấu trúc rẽ nhánh
////3.1. if..else
//if (age < 18)
//{
//    Console.WriteLine("Reject!");
//}
//else
//{
//    Console.WriteLine("Accept!");
//}
////3.2. Switch case
////4. Vòng lặp
////4.1. for
////4.2. while
////4.3. do..while
////4.4. foreach

//List<double> scores = [1.2, 2.2, 3.3, 4.4, 8.8, 9.9];
//foreach (double score in scores)
//{
//    Console.WriteLine(score);
//}


/*
5. Hướng đối tượng (OOP)
- 4 tính chất trong OOP
    + kế thừa: Lớp con kế thừa thuộc tính và phương thức của lớp cha
    + đa hình: Upcasting & Dowcasting
    + trừu tượng: Trừu tượng hóa đối tượng trong thực tế chỉ giữ lại những gì cần thiết
    + đóng gói: Chuyển mức độ truy cập của các thuộc tính thành thành private và thêm các phương thức get/set
- C# có 5 loại mức độ truy cập:
    + public: Công khai ai dùng cũng được
    + private: Riêng tư, không ai ngoài mình thấy được
    + protected:  Chỉ cho phép lớp con kế thừa có thể sử dụng
    + internal: Nội bộ trong namespace
    + protected internal: Kết hợp protected và internal
- 1 class sẽ có 3 thành phần
    + Property (thuộc tính của đối tượng)
    + Method (Phương thức đối tượng)
    + Constructor (Phương thức khởi tạo): 2 loaoij có tham số và không có tham số
 */
using Lesson01;

///*
//khai báo và hởi tạo đối tượng 
//Cú pháp: Tên-lớp tên-dối-tượng = new constructor();
Student student = new Student(id: 1771020502, name: "NTHN", age: 20);
//Để truy cập đến thuộc tính hoặc phương thức của dối tượng sử dụng dấu
//Console.WriteLine(student.Id);
//student.getStudentInfo();
//student.Name = "NTHN";
//student.getStudentInfo();
student.inputStudent();
student.getStudentInfo();
//6. Xử lí ngoại lệ 
//- có 2 loại ngoại lệ:
// + Complilation Errors
// + Runtime Errors 
//-Xử lý try...catch...finally
//-Tung ngoại lệ cưỡng bức
//-Tự định nghĩa ngoại lệ 

