using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudwithCollectionsStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            StudentCRUD crud = new StudentCRUD();
            do
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine("1. Student List");
                Console.WriteLine("2. Get Student by Id");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Student");
                Console.WriteLine("5.Delete Student");
                Console.WriteLine("Select the option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Student> list = crud.GetStudents();
                        Console.WriteLine("RollNo \t Name \t Percentage \t CollegeName \t");
                        foreach (Student s in list)
                        {
                            Console.WriteLine($"{s.RollNo}{s.Name}{s.Percentage}{s.CollegeName}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Student RollNo");
                        int rollno = Convert.ToInt32(Console.ReadLine());
                        Student s1 = crud.GetStudentByRollNo(rollno);
                        Console.WriteLine("RollNo \t Name \t Percentage \t CollegeName \t");
                        Console.WriteLine($"{s1.RollNo}{s1.Name}{s1.Percentage}{s1.CollegeName}");
                        break;
                    case 3:
                        Student s2 = new Student();
                        Console.WriteLine("Enter Student RollNo");
                        s2.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s2.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Student Percentage");
                        s2.Percentage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter CollegeName");
                        s2.CollegeName = Convert.ToString(Console.ReadLine());
                        crud.AddStudent(s2);
                        Console.WriteLine("Data saved Sucessfully...");
                        break;
                    case 4:
                        Student s3 = new Student();
                        Console.WriteLine("Enter Student RollNo");
                        s3.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s3.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Student Percentage");
                        s3.Percentage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter CollegeName");
                        s3.CollegeName = Convert.ToString(Console.ReadLine());
                        crud.AddStudent(s3);
                        Console.WriteLine("Data saved Sucessfully...");
                        break;
                    case 5:
                        Console.WriteLine("Enter Student RollNo");
                        int rollno2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(rollno2);
                        Console.WriteLine($"{rollno2} student deleted...");
                        break;
                }
                Console.WriteLine("Press 1 to Continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);



















































        }

    }
}



