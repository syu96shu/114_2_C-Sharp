namespace 員工資料管理系統
{
    public class EditEmployeeForm : Form
    {
        private List<Employee> employeeList;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox departmentTextBox;
        private TextBox positionTextBox;
        private Button searchButton;
        private Button saveButton;
        private Button closeButton;
        private Employee current;
        private ListBox messageListBox;

        public EditEmployeeForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "修改員工資料";
            this.ClientSize = new Size(420, 300);

            var lbl1 = new Label() { Text = "員工編號", Location = new Point(12, 15), AutoSize = true };
            idTextBox = new TextBox() { Location = new Point(120, 12), Width = 250 };

            searchButton = new Button() { Text = "查詢", Location = new Point(120, 42), Width = 80 };
            searchButton.Click += QueryButton_Click;

            var lbl2 = new Label() { Text = "姓名", Location = new Point(12, 80), AutoSize = true };
            nameTextBox = new TextBox() { Location = new Point(120, 77), Width = 250 };

            var lbl3 = new Label() { Text = "部門", Location = new Point(12, 115), AutoSize = true };
            departmentTextBox = new TextBox() { Location = new Point(120, 112), Width = 250 };

            var lbl4 = new Label() { Text = "職稱", Location = new Point(12, 150), AutoSize = true };
            positionTextBox = new TextBox() { Location = new Point(120, 147), Width = 250 };

            saveButton = new Button() { Text = "儲存", Location = new Point(120, 185), Width = 80 };
            saveButton.Click += SaveButton_Click;

            closeButton = new Button() { Text = "離開", Location = new Point(210, 185), Width = 80 };
            closeButton.Click += (s, e) => this.Close();

            messageListBox = new ListBox() { Location = new Point(12, 220), Size = new Size(388, 70) };

            this.Controls.AddRange(new Control[] { lbl1, idTextBox, searchButton, lbl2, nameTextBox, lbl3, departmentTextBox, lbl4, positionTextBox, saveButton, closeButton, messageListBox });
        }

        private void QueryButton_Click(object? sender, EventArgs e)
        {
            messageListBox.Items.Clear();

            if (!int.TryParse(idTextBox.Text.Trim(), out var id))
            {
                var msg = "員工編號格式錯誤";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            current = employeeList.FirstOrDefault(x => x.IdNumber == id);
            if (current == null)
            {
                var msg = "找不到員工";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            nameTextBox.Text = current.Name;
            departmentTextBox.Text = current.Department;
            positionTextBox.Text = current.Position;
            messageListBox.Items.Add("查詢成功");
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            messageListBox.Items.Clear();

            if (current == null)
            {
                var msg = "請先查詢員工";
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

            current.Name = name;
            current.Department = departmentTextBox.Text.Trim();
            current.Position = positionTextBox.Text.Trim();

            var success = "儲存成功";
            MessageBox.Show(success);
            messageListBox.Items.Add(success);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
