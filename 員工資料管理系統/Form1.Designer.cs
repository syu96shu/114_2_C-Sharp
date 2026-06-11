namespace 員工資料管理系統
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.searchEmployeeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(140, 32);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "員工資料管理";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 50);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(120, 35);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "新增員工";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(138, 50);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(120, 35);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "刪除員工";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(264, 50);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(120, 35);
            this.editEmployeeButton.TabIndex = 2;
            this.editEmployeeButton.Text = "修改員工";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // searchEmployeeButton
            // 
            this.searchEmployeeButton.Location = new System.Drawing.Point(390, 50);
            this.searchEmployeeButton.Name = "searchEmployeeButton";
            this.searchEmployeeButton.Size = new System.Drawing.Size(120, 35);
            this.searchEmployeeButton.TabIndex = 3;
            this.searchEmployeeButton.Text = "查詢員工";
            this.searchEmployeeButton.UseVisualStyleBackColor = true;
            this.searchEmployeeButton.Click += new System.EventHandler(this.searchEmployeeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(516, 50);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 35);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 20;
            this.employeeListBox.Location = new System.Drawing.Point(12, 95);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(760, 340);
            this.employeeListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchEmployeeButton);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "員工資料管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button searchEmployeeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Label titleLabel;
    }
}
