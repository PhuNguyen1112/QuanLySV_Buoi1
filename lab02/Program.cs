using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student(123, " AN", 18),
            new Student(234, "BAO", 32),
            new Student(345, "CHAU", 17),
            new Student(456, "DANH", 20),
            new Student(567, "PHU", 18)
        };
            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var b = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
            foreach (var student in b)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ 'A'
            var c = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nDanh sách học sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var student in c)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            // d. Tính tổng tuổi của tất cả học sinh
            int sum = students.Sum(s => s.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {sum}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var e = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: ID: {e.Id}, Name: {e.Name}, Age: {e.Age}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var f = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var student in f)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
