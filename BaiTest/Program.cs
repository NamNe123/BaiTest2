using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo mảng học sinh
            var students = new List<Student>
            {
                new Student("nguyen van A", 10, 9, 8),
                new Student("nguyen van B", 8, 7, 9),
                new Student("nguyen van C", 9, 10, 10),
                new Student("nguyen van D", 7, 6, 8),
                new Student("nguyen van E", 8, 8, 8),
                new Student("nguyen van F", 9, 8, 9)
            };
            // b. Sắp xếp mảng theo điểm trung bình giảm dần, và theo "name" nếu điểm trung bình bằng nhau
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - 1 - i; j++)
                {
                    double avgScore1 = students[j].GetAverageScore();
                    double avgScore2 = students[j + 1].GetAverageScore();

                    if (avgScore1 < avgScore2 || (avgScore1 == avgScore2 && string.Compare(students[j].Name, students[j + 1].Name) > 0))
                    {
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sách học sinh sau khi sắp xếp:");
            foreach (var student in students)
            {
                Console.WriteLine($"- Họ tên: {student.Name}, Điểm TB: {student.GetAverageScore()}");
            }
            // c. Tìm kiếm học sinh có điểm trung bình bằng 8
            foreach (var student in students)
            {
                if (student.GetAverageScore() == 8)  // Kiểm tra điểm trung bình bằng 8
                {
                    Console.WriteLine($"Học sinh có điểm trung bình bằng 8: {student.Name}");
                }
            }
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
       

        
    }
}
