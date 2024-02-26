namespace Lab3Student
{
    public partial class Form1 : Form
    {

        int selectedIndex = 0;
        List<Student> Studentslist = new List<Student>();
        StudentDB DB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Studentslist.Clear();
            DB = new StudentDB(Studentslist);
            DB.ExampleStudent();
            LoadStudentListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int totalScore = 0;
                int assignmentsCount = 0;
                foreach (var assignment in Studentslist[listBox1.SelectedIndex].AssignmentsDetails)
                {
                    if (assignment != null) 
                    {
                        totalScore += assignment.Score;
                        assignmentsCount++;
                    }
                }
                if (assignmentsCount != 0) 
                {
                    int averageScore = totalScore / assignmentsCount;
                    txtTotal.Text = totalScore.ToString();
                    txtAverage.Text = averageScore.ToString();
                    txtCount.Text = assignmentsCount.ToString();
                }
                else
                {
                    txtTotal.Text = "0";
                    txtAverage.Text = "0";
                    txtCount.Text = "0";
                }
            }
        }


        private void buttonPerform_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;

            if (rdbAdd.Checked)
            {
                Form2 form2 = new Form2(Studentslist);
                form2.ShowDialog();
                LoadStudentListBox();
            }
            else if (rdbUpdate.Checked)
            {
                if (selectedIndex == -1)
                {
                    MessageBox.Show("Select Student Please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Form3 form3 = new Form3(Studentslist, Studentslist[selectedIndex]);
                form3.ShowDialog();
                LoadStudentListBox();
            }

            else if (rdbDelete.Checked)
            {
                if (selectedIndex != -1)
                {
                    DB.DeleteStudent(selectedIndex);
                    LoadStudentListBox();
                }
            }
            else if (rdbExit.Checked)
            {
                this.Close();
            }
        }

        public void LoadStudentListBox(int selectIndex = 0)
        {
            listBox1.Items.Clear();

            foreach (Student s in Studentslist)
            {
                listBox1.Items.Add(s);
            }

            if (listBox1.Items.Count > 0)
            {
                selectedIndex = listBox1.SelectedIndex;

            }
            else
            {
                txtTotal.Text = "";
                txtCount.Text = "";
                txtAverage.Text = "";
            }
            listBox1.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Studentslist);
            form2.ShowDialog();
            LoadStudentListBox();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Select Student Please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form3 form3 = new Form3(Studentslist, Studentslist[selectedIndex]);
            form3.ShowDialog();
            LoadStudentListBox();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex != -1)
            {
                DB.DeleteStudent(selectedIndex);
                LoadStudentListBox();
            }
        }
    }
}
