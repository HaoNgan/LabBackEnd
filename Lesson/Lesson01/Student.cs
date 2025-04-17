using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Student
    {
        //1. Properties
        //private int id;

        //public int Id
        //{
        //get { return id; }
        //set { id = value; }
        //}
        //Cách 2
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        //2. Constructors
        //2.1. k có tham số (duy nhất)
        public Student() { }
        //2.2. Có tham số (có thể viết được nhiều) 
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        //3. Method
        public void getStudentInfo()
        {
            Console.WriteLine("Student Info: ");
            Console.WriteLine($"\t- Id: {Id}");
            Console.WriteLine($"\t- Name: {Name}");
            Console.WriteLine($"\t- Age: {Age}");
        }
        public void inputStudent()
        {
            try//code có thể xảy ra lỗi
            {
                Console.WriteLine("Input Student: ");
                Console.Write("\t- Id: ");
                Id = int.Parse(Console.ReadLine());
                Console.Write("\t- Name: ");
                Name = Console.ReadLine();

                Console.Write("\t- Age: ");
                int value = int.Parse(Console.ReadLine());
                //tung ngoại lệ cưỡng bức
                if (value < 0)
                {
                    throw new AgeException("nhập sai");
                }
                Age = value;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//xử lý khi lỗi xảy ra 
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally//khối lệnh luôn luôn dược thực thi
            {
                Console.WriteLine("luôn luôn dược thực thi");
            }
        }
    }
}
