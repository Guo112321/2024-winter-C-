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
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public double TotalScore { get; set; }
        public double TotalMaxScore { get; set; }
        public Assignment[] AssignmentsDetails { get; set; }

        public Student(string studentID, string studentName)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            AssignmentsDetails = new Assignment[5];
        }

        public Student()
        {
            AssignmentsDetails = new Assignment[5];
        }

        public override string ToString()
        {
            string studentInfo = StudentName;
            if (AssignmentsDetails != null)
            {
                foreach (var assignment in AssignmentsDetails)
                {
                    if (assignment != null) 
                    {
                        studentInfo += "|";
                        studentInfo += assignment.Score.ToString();
                    }
                }
            }
            return studentInfo;
        }

    }
}
