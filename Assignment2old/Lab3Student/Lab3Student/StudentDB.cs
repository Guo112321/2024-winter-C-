using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab3Student
{
    public class StudentDB
    {

        public List<Student> Studentslist;

        public StudentDB(List<Student> Studentslist)
        {
            this.Studentslist = Studentslist;
        }
        public void ExampleStudent()
        {
            string studentName1 = "Joel Garner";
            Student student1 = new Student("01", studentName1);
            student1.AssignmentsDetails[0] = new Assignment("001", 97, 100);
            student1.AssignmentsDetails[1] = new Assignment("002", 91, 100);
            student1.AssignmentsDetails[2] = new Assignment("003", 83, 100);
            Studentslist.Add(student1);

            string studentName2 = "Doug Lowo";
            Student student2 = new Student("02", studentName2);
            student2.AssignmentsDetails[0] = new Assignment("001", 99, 100);
            student2.AssignmentsDetails[1] = new Assignment("002", 93, 100);
            student2.AssignmentsDetails[2] = new Assignment("003", 97, 100);
            Studentslist.Add(student2);

            string studentName3 = "Anne Boehm";
            Student student3 = new Student("03", studentName3);
            student3.AssignmentsDetails[0] = new Assignment("001", 100, 100);
            student3.AssignmentsDetails[1] = new Assignment("002", 100, 100);
            student3.AssignmentsDetails[2] = new Assignment("003", 100, 100);
            Studentslist.Add(student3);
        }


        public int CheckScore(string enterScore)
        {
            int score;
            bool result = int.TryParse(enterScore, out score);

            if ((!result) && enterScore == "")
            {
                MessageBox.Show("Enter Score please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                score = -1;
            }
            else if (score > 100  || score < 0)
            {
                MessageBox.Show("not Valid Score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                score = -1;
            }
            return score;
        }

        public bool AddStudent(string enterName, string enterScore, string enterStudentID, string enterStudentAssignmentID, Student student, List<Student> Studentslist)
        {
            int score = CheckScore(enterScore);
            bool result = score == -1;
            if (result)
            {
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(student.StudentName))
                {
                    if (string.IsNullOrEmpty(enterName))
                    {
                        MessageBox.Show("Enter Name please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    foreach (Student s in Studentslist)
                    {
                        if (s.StudentName.Equals(enterName))
                        {
                            MessageBox.Show("Duplicate Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    student.StudentName = enterName;
                    student.StudentID = enterStudentID;

                    if (student.AssignmentsDetails[0] == null)
                    {
                        student.AssignmentsDetails[0] = new Assignment();
                    }
                    student.AssignmentsDetails[0].AssignmentID = enterStudentAssignmentID;
                    student.AssignmentsDetails[0].Score = score;
                    return true;
                }
                else if (enterName == student.StudentName)
                {
                    foreach (var assignment in student.AssignmentsDetails)
                    {
                        if (assignment != null && assignment.AssignmentID == enterStudentAssignmentID)
                        {
                            MessageBox.Show("Duplicate Assignment ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    for (int i = 0; i < student.AssignmentsDetails.Length; i++)
                    {
                        if (student.AssignmentsDetails[i] == null)
                        {
                            student.AssignmentsDetails[i] = new Assignment();
                            student.AssignmentsDetails[i].AssignmentID = enterStudentAssignmentID;
                            student.AssignmentsDetails[i].Score = score;
                            return true;
                        }
                    }
                    MessageBox.Show("Student has reached the maximum number of assignments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    student.StudentName = enterName;
                    student.StudentID = enterStudentID;

                    if (student.AssignmentsDetails[0] == null)
                    {
                        student.AssignmentsDetails[0] = new Assignment();
                    }
                    student.AssignmentsDetails[0].AssignmentID = enterStudentAssignmentID;
                    student.AssignmentsDetails[0].Score = score;
                    return true;
                }
            }
        }



        public bool UpdataStudentNewScore(string enterScore, Student student, string enterID)
        {
            int score = CheckScore(enterScore);
            if (score == -1)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < student.AssignmentsDetails.Length; i++)
                {
                    if (student.AssignmentsDetails[i] == null)
                    {
                        student.AssignmentsDetails[i] = new Assignment();
                        student.AssignmentsDetails[i].Score = score;
                        student.AssignmentsDetails[i].AssignmentID = enterID;
                        return true;
                    }
                }
                MessageBox.Show("Student has reached the maximum number of assignments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateStudentUpdateScore(string enterScore, Student student, int index, string enterID)
        {
            int score = CheckScore(enterScore);
            if (score == -1)
            {
                return false;
            }
            else
            {
                if (index >= 0 && index < student.AssignmentsDetails.Length)
                {
                    student.AssignmentsDetails[index].Score = score;
                    student.AssignmentsDetails[index].AssignmentID = enterID;
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid assignment index", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public void DeleteStudent(int index)
        {
            Studentslist.RemoveAt(index);
        }
    }
}
