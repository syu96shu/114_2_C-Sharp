namespace 員工資料管理系統
{
    public class SearchEmployeeForm : Form
    {
        private List<Employee> employeeList;
        private TextBox idTextBox;
        private Button searchButton;
        private Button closeButton;
        private Label idResultLabel;
        private Label nameResultLabel;
        private Label departmentResultLabel;
        private Label positionResultLabel;

        public SearchEmployeeForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "查詢員工";
            this.ClientSize = new Size(420, 260);

            var lbl = new Label() { Text = "員工編號", Location = new Point(12, 15), AutoSize = true };
            idTextBox = new TextBox() { Location = new Point(120, 12), Width = 250 };

            searchButton = new Button() { Text = "查詢", Location = new Point(120, 42), Width = 80 };
            searchButton.Click += QueryButton_Click;

            idResultLabel = new Label() { Text = "員工編號：", Location = new Point(12, 80), AutoSize = true };
            nameResultLabel = new Label() { Text = "姓名：", Location = new Point(12, 110), AutoSize = true };
            departmentResultLabel = new Label() { Text = "部門：", Location = new Point(12, 140), AutoSize = true };
            positionResultLabel = new Label() { Text = "職稱：", Location = new Point(12, 170), AutoSize = true };

            closeButton = new Button() { Text = "離開", Location = new Point(120, 200), Width = 80 };
            closeButton.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] { lbl, idTextBox, searchButton, idResultLabel, nameResultLabel, departmentResultLabel, positionResultLabel, closeButton });
        }

        private void QueryButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(idTextBox.Text.Trim(), out var id))
            {
                MessageBox.Show("員工編號格式錯誤");
                ClearResults();
                return;
            }

            var emp = employeeList.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                MessageBox.Show("找不到員工");
                ClearResults();
                return;
            }

            idResultLabel.Text = "員工編號：" + emp.IdNumber;
            nameResultLabel.Text = "姓名：" + emp.Name;
            departmentResultLabel.Text = "部門：" + emp.Department;
            positionResultLabel.Text = "職稱：" + emp.Position;
        }

        private void ClearResults()
        {
            idResultLabel.Text = "員工編號：";
            nameResultLabel.Text = "姓名：";
            departmentResultLabel.Text = "部門：";
            positionResultLabel.Text = "職稱：";
        }
    }
}
