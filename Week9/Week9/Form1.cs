using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCsv();
        }

        List<Employee> employees;
        List<EmployeeCountry> employeeCountries;

        public void LoadCsv()
        {
            using (var reader = new StreamReader("EmployeeData.csv"))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                employees = csv.GetRecords<Employee>().ToList();
            }

            using (var reader = new StreamReader("EmployeeCountry.csv"))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                employeeCountries = csv.GetRecords<EmployeeCountry>().ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var list = from Employee in employees
                       join EmployeeCountry in employeeCountries
                       on Employee.EmployeeId equals EmployeeCountry.EmployeeId
                       where Employee.Age > 40
                       select new { Employee.Name };
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Name);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var list = from Employee in employees
                       join EmployeeCountry in employeeCountries
                       on Employee.EmployeeId equals EmployeeCountry.EmployeeId
                       select new { Employee.Department };
            list = list.Distinct();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Department);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var list = from Employee in employees
                       select new { Employee.Salary };
            decimal ave = employees.Average(x => x.Salary);
            listBox1.Items.Add(ave);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = from Employee in employees
                       join EmployeeCountry in employeeCountries
                       on Employee.EmployeeId equals EmployeeCountry.EmployeeId
                       where EmployeeCountry.CountryName.Equals("Canada")
                       select new { Employee.Name, EmployeeCountry.CountryName };
            foreach(var item in list)
            {
                listBox1.Items.Add($"Name: {item.Name}, Country: {item.CountryName}");
            }

        }
    }
}
