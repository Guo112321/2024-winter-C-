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
            foreach (int i in student.Score)
            {
                ScoreListBox.Items.Add(i);
            }
        }


        private void ScoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result = DB.UpdataStudentNewScore(txtScore.Text, student);
            if (!result) 
            {
                return;
            }
            LoadListBox();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = DB.UpdateStudentUpdateScore(txtScore.Text, student, ScoreListBox.SelectedIndex);
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
    }
}
