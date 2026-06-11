using System.Text;

namespace 員工資料管理系統
{
    public partial class Form1 : Form
    {
        private List<Employee> employeeList = new List<Employee>();
        private readonly string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            RefreshListBox();
        }

        private void LoadEmployees()
        {
            employeeList.Clear();
            if (!File.Exists(dataFile))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(dataFile, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                if (parts.Length < 4) continue;
                if (!int.TryParse(parts[0], out var id)) continue;
                var emp = new Employee(id, parts[1], parts[2], parts[3]);
                employeeList.Add(emp);
            }
        }

        private void SaveEmployees()
        {
            var lines = employeeList.Select(e => $"{e.IdNumber}|{e.Name}|{e.Department}|{e.Position}");
            File.WriteAllLines(dataFile, lines, Encoding.UTF8);
        }

        private void RefreshListBox()
        {
            employeeListBox.Items.Clear();
            foreach (var emp in employeeList)
            {
                employeeListBox.Items.Add(emp.ToString());
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var dlg = new AddEmployeeForm(employeeList);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var dlg = new DeleteEmployeeForm(employeeList);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
            }
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            var dlg = new EditEmployeeForm(employeeList);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
            }
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            var dlg = new SearchEmployeeForm(employeeList);
            dlg.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployees();
        }
    }
}
