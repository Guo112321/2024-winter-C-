using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> studentScore1 = new List<int> { 97, 91, 83 };
            Student student1 = new Student(studentName1, studentScore1);
            Studentslist.Add(student1);

            string studentName2 = "Doug Lowo";
            List<int> studentScore2 = new List<int> { 99, 93, 97 };
            Student student2 = new Student(studentName2, studentScore2);
            Studentslist.Add(student2);

            string studentName3 = "Anne Boehm";
            List<int> studentScore3 = new List<int> { 100, 100, 100 };
            Student student3 = new Student(studentName3, studentScore3);
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

        public bool AddStudent (string enterName, string enterScore, Student student, List<Student> Studentslist)
        {
            int score = CheckScore(enterScore);
            bool result = score == -1;
            if(result)
            {
                return false;
            }
            else
            {
                if (student.StudentName == "")
                {
                    if (enterName == "")
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
                    student.Score.Add(score);
                    return true;
                }
                else if (enterName == student.StudentName)
                {
                    student.Score.Add(score);
                    return true;
                }
                else
                {
                    student.StudentName = enterName;
                    student.Score.Add(score);
                    return true;
                }
            }
            
        }

        public bool UpdataStudentNewScore (string enterScore, Student student)
        {
            if(CheckScore(enterScore) == -1)
            {
                return false;
            }
            else
            {
                student.Score.Add(CheckScore(enterScore));
                return true;
            }
        }

        public bool UpdateStudentUpdateScore(string enterScore, Student student, int index)
        {
            if (CheckScore(enterScore) == -1)
            {
                return false;
            }
            else
            {
                student.Score[index] = CheckScore(enterScore);
                return true;
            }
        }

        public void DeleteStudent(int index)
        {
            Studentslist.RemoveAt(index);
        }
    }
}
