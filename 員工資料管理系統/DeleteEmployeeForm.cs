namespace 員工資料管理系統
{
    public class DeleteEmployeeForm : Form
    {
        private List<Employee> employeeList;
        private TextBox idTextBox;
        private Button deleteButton;
        private Button closeButton;
        private ListBox messageListBox;

        public DeleteEmployeeForm(List<Employee> employeeList)
        {
            this.employeeList = employeeList;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "刪除員工";
            this.ClientSize = new Size(350, 220);

            var lbl = new Label() { Text = "員工編號", Location = new Point(12, 15), AutoSize = true };
            idTextBox = new TextBox() { Location = new Point(120, 12), Width = 200 };

            deleteButton = new Button() { Text = "刪除", Location = new Point(120, 50), Width = 80 };
            deleteButton.Click += DeleteButton_Click;

            closeButton = new Button() { Text = "離開", Location = new Point(210, 50), Width = 80 };
            closeButton.Click += (s, e) => this.Close();

            messageListBox = new ListBox() { Location = new Point(12, 90), Size = new Size(320, 120) };

            this.Controls.AddRange(new Control[] { lbl, idTextBox, deleteButton, closeButton, messageListBox });
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            messageListBox.Items.Clear();

            if (!int.TryParse(idTextBox.Text.Trim(), out var id))
            {
                var msg = "員工編號格式錯誤";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            var emp = employeeList.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                var msg = "找不到員工";
                MessageBox.Show(msg);
                messageListBox.Items.Add(msg);
                return;
            }

            employeeList.Remove(emp);
            var success = "刪除成功";
            MessageBox.Show(success);
            messageListBox.Items.Add(success);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
