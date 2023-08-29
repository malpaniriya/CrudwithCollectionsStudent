using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudwithCollectionsStudent
{
    public class Student
    {
        
        public int RollNo { get; set; }
        public string Name { get; set; }

        public double Percentage { get; set; }

        public string CollegeName { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student> studentlist;
        public StudentCRUD()
        {
            studentlist = new List<Student>()
            {
                new Student {RollNo=01,Name="Riya Malpani",Percentage=91,CollegeName="NMIMS"},
                new Student { RollNo = 02, Name = " Yash Shah", Percentage = 80, CollegeName = "FC" }
            };
        }
        public List<Student> GetStudents()
        {
            return studentlist;
        }
        public Student GetStudentByRollNo(int rollNo)
        {
            Student student = new Student();
            foreach (Student s in studentlist)
            {
                if (s.RollNo == rollNo)
                {
                    student = s;
                    break;
                }
            }
            return student;
        }
        public void AddStudent(Student s)
        {
            studentlist.Add(s);
        }

        public void UpdateStudent(Student s)
        {
            foreach (Student student in studentlist)
            {
                if (student.RollNo == s.RollNo)
                {
                    student.RollNo = s.RollNo;
                    student.Name = s.Name;
                    student.Percentage = s.Percentage;
                    student.CollegeName = s.CollegeName;
                }
            }
        }

        public void DeleteStudent(int rollNo)
        {
            foreach (Student student in studentlist)
            {
                if (student.RollNo == rollNo)
                {
                    studentlist.Remove(student);
                    break;
                }
            }
        }
    }
}
    

