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
    public partial class Form2 : Form
    {
        List<Student> Studentslist;
        StudentDB DB;
        public Form2(List<Student> Studentslist)
        {
            this.Studentslist = Studentslist;
            InitializeComponent();
        }

        Student student = new Student();

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            bool result = DB.AddStudent(txtStudentName.Text, txtStudentScore.Text, txtStudentID.Text, txtsStudentScoreID.Text, student, Studentslist);
            if (!result)
            {
                return;
            }

            labelStudentInfo.Text = student.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Studentslist.Add(student);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DB = new StudentDB(Studentslist);
        }
    }
}
