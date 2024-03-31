using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Student
{
    public partial class Form3 : Form
    {
        List<Student> Studentslist;
        StudentDB DB;
        Student student;

        public Form3(List<Student> Studentslist, Student student)
        {
            InitializeComponent();
            this.Studentslist = Studentslist;
            this.student = student;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadListBox();
            DB = new StudentDB(Studentslist);
        }

        private void LoadListBox()
        {
            labelStudentInfo.Text = student.StudentName;
            ScoreListBox.Items.Clear();
            foreach (var assignment in student.AssignmentsDetails)
            {
                if (assignment != null)

                {
                    ScoreListBox.Items.Add($"Assignment ID: {assignment.AssignmentID}, Score: {assignment.Score}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result = DB.UpdataStudentNewScore(txtScore.Text, student,txtID.Text);
            if (!result)
            {
                return;
            }
            LoadListBox();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = DB.UpdateStudentUpdateScore(txtScore.Text, student, ScoreListBox.SelectedIndex, txtID.Text);
            if (!result)
            {
                return;
            }
            LoadListBox();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ScoreListBox.SelectedIndex != -1)
            {
                student.AssignmentsDetails[ScoreListBox.SelectedIndex] = null;
                LoadListBox();
            }
        }
    }
}
