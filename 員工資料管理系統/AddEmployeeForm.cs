using System.Text;

namespace 員工資料管理系統
{
    public class AddEmployeeForm : Form
    {
        private List<Employee> employeeList;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox departmentTextBox;
        private TextBox positionTextBox;
        private Button addButton;
        private Button closeButton;
        private ListBox messageListBox;

        public AddEmployeeForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "新增員工";
            this.ClientSize = new Size(420, 300);

            var lbl1 = new Label() { Text = "員工編號", Location = new Point(12, 15), AutoSize = true };
            idTextBox = new TextBox() { Location = new Point(120, 12), Width = 280 };

            var lbl2 = new Label() { Text = "姓名", Location = new Point(12, 50), AutoSize = true };
            nameTextBox = new TextBox() { Location = new Point(120, 47), Width = 280 };

            var lbl3 = new Label() { Text = "部門", Location = new Point(12, 85), AutoSize = true };
            departmentTextBox = new TextBox() { Location = new Point(120, 82), Width = 280 };

            var lbl4 = new Label() { Text = "職稱", Location = new Point(12, 120), AutoSize = true };
            positionTextBox = new TextBox() { Location = new Point(120, 117), Width = 280 };

            addButton = new Button() { Text = "新增", Location = new Point(120, 150), Width = 100 };
            addButton.Click += AddButton_Click;

            closeButton = new Button() { Text = "離開", Location = new Point(230, 150), Width = 100 };
            closeButton.Click += (s, e) => this.Close();

            messageListBox = new ListBox() { Location = new Point(12, 190), Size = new Size(388, 90) };

            this.Controls.AddRange(new Control[] { lbl1, idTextBox, lbl2, nameTextBox, lbl3, departmentTextBox, lbl4, positionTextBox, addButton, closeButton, messageListBox });
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            messageListBox.Items.Clear();

            if (!int.TryParse(idTextBox.Text.Trim(), out var id))
            {
                var msg = "員工編號格式錯誤";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            var name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                var msg = "姓名不可空白";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            if (employeeList.Any(x => x.IdNumber == id))
            {
                var msg = "員工編號已存在";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            var emp = new Employee(id, name, departmentTextBox.Text.Trim(), positionTextBox.Text.Trim());
            employeeList.Add(emp);
            var success = "新增成功";
            MessageBox.Show(success);
            messageListBox.Items.Add(success);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
