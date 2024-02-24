using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Student
{
    public class Student
    {
        public string StudentName {  get; set; }
        public List<int> Score = new List<int> { };
        public Student(string studentName, List<int> score) 
        {
            this .StudentName = studentName;
            this .Score = score;
        }

        public Student()
        {
            this.StudentName = "";
            this.Score = new List<int>();
        }

        public override string ToString()
        {
            string studentInfo = StudentName;
            foreach (int i in Score)
            {
                studentInfo += "|";
                studentInfo += i.ToString();
            }
            return studentInfo;
        }
    }
}
