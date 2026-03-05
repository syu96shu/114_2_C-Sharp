namespace review_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Service checkboxes
        private System.Windows.Forms.GroupBox groupBoxOil;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLubeJob;

        private System.Windows.Forms.GroupBox groupBoxCleaning;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox groupBoxParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;

        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label lblServiceAndLabor;
        private System.Windows.Forms.TextBox txtServiceAndLabor;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblPartsTax;
        private System.Windows.Forms.TextBox txtPartsTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOil = new GroupBox();
            chkChangeOil = new CheckBox();
            chkLubeJob = new CheckBox();
            groupBoxCleaning = new GroupBox();
            chkRadiatorFlush = new CheckBox();
            chkTransmissionFlush = new CheckBox();
            groupBoxOther = new GroupBox();
            chkInspection = new CheckBox();
            chkReplaceMuffler = new CheckBox();
            chkTireRotation = new CheckBox();
            groupBoxParts = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblHours = new Label();
            txtHours = new TextBox();
            groupBoxSummary = new GroupBox();
            lblServiceAndLabor = new Label();
            txtServiceAndLabor = new TextBox();
            lblPartsCost = new Label();
            txtPartsCost = new TextBox();
            lblPartsTax = new Label();
            txtPartsTax = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBoxOil.SuspendLayout();
            groupBoxCleaning.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxParts.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOil
            // 
            groupBoxOil.Controls.Add(chkChangeOil);
            groupBoxOil.Controls.Add(chkLubeJob);
            groupBoxOil.Location = new Point(12, 12);
            groupBoxOil.Name = "groupBoxOil";
            groupBoxOil.Size = new Size(240, 80);
            groupBoxOil.TabIndex = 0;
            groupBoxOil.TabStop = false;
            groupBoxOil.Text = "機油和潤滑";
            // 
            // chkChangeOil
            // 
            chkChangeOil.Location = new Point(10, 22);
            chkChangeOil.Name = "chkChangeOil";
            chkChangeOil.Size = new Size(200, 20);
            chkChangeOil.TabIndex = 0;
            chkChangeOil.Text = "更換機油 (NT$780)";
            // 
            // chkLubeJob
            // 
            chkLubeJob.Location = new Point(10, 44);
            chkLubeJob.Name = "chkLubeJob";
            chkLubeJob.Size = new Size(200, 20);
            chkLubeJob.TabIndex = 1;
            chkLubeJob.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxCleaning
            // 
            groupBoxCleaning.Controls.Add(chkRadiatorFlush);
            groupBoxCleaning.Controls.Add(chkTransmissionFlush);
            groupBoxCleaning.Location = new Point(268, 12);
            groupBoxCleaning.Name = "groupBoxCleaning";
            groupBoxCleaning.Size = new Size(240, 80);
            groupBoxCleaning.TabIndex = 1;
            groupBoxCleaning.TabStop = false;
            groupBoxCleaning.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.Location = new Point(10, 22);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new Size(200, 20);
            chkRadiatorFlush.TabIndex = 0;
            chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransmissionFlush
            // 
            chkTransmissionFlush.Location = new Point(10, 44);
            chkTransmissionFlush.Name = "chkTransmissionFlush";
            chkTransmissionFlush.Size = new Size(200, 20);
            chkTransmissionFlush.TabIndex = 1;
            chkTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(chkInspection);
            groupBoxOther.Controls.Add(chkReplaceMuffler);
            groupBoxOther.Controls.Add(chkTireRotation);
            groupBoxOther.Location = new Point(12, 100);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(240, 100);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.Location = new Point(10, 22);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(200, 20);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkReplaceMuffler
            // 
            chkReplaceMuffler.Location = new Point(10, 44);
            chkReplaceMuffler.Name = "chkReplaceMuffler";
            chkReplaceMuffler.Size = new Size(220, 20);
            chkReplaceMuffler.TabIndex = 1;
            chkReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            chkTireRotation.Location = new Point(10, 66);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new Size(200, 20);
            chkTireRotation.TabIndex = 2;
            chkTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // groupBoxParts
            // 
            groupBoxParts.Controls.Add(lblParts);
            groupBoxParts.Controls.Add(txtParts);
            groupBoxParts.Controls.Add(lblHours);
            groupBoxParts.Controls.Add(txtHours);
            groupBoxParts.Location = new Point(268, 100);
            groupBoxParts.Name = "groupBoxParts";
            groupBoxParts.Size = new Size(240, 100);
            groupBoxParts.TabIndex = 3;
            groupBoxParts.TabStop = false;
            groupBoxParts.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.Location = new Point(10, 24);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(80, 20);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(90, 22);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(120, 30);
            txtParts.TabIndex = 1;
            // 
            // lblHours
            // 
            lblHours.Location = new Point(10, 56);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(80, 20);
            lblHours.TabIndex = 2;
            lblHours.Text = "工時 (小時)";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(90, 54);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(120, 30);
            txtHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(lblServiceAndLabor);
            groupBoxSummary.Controls.Add(txtServiceAndLabor);
            groupBoxSummary.Controls.Add(lblPartsCost);
            groupBoxSummary.Controls.Add(txtPartsCost);
            groupBoxSummary.Controls.Add(lblPartsTax);
            groupBoxSummary.Controls.Add(txtPartsTax);
            groupBoxSummary.Controls.Add(lblTotal);
            groupBoxSummary.Controls.Add(txtTotal);
            groupBoxSummary.Location = new Point(12, 210);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(496, 110);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // lblServiceAndLabor
            // 
            lblServiceAndLabor.Location = new Point(10, 24);
            lblServiceAndLabor.Name = "lblServiceAndLabor";
            lblServiceAndLabor.Size = new Size(120, 20);
            lblServiceAndLabor.TabIndex = 0;
            lblServiceAndLabor.Text = "服務與工資";
            // 
            // txtServiceAndLabor
            // 
            txtServiceAndLabor.Location = new Point(140, 22);
            txtServiceAndLabor.Name = "txtServiceAndLabor";
            txtServiceAndLabor.ReadOnly = true;
            txtServiceAndLabor.Size = new Size(140, 30);
            txtServiceAndLabor.TabIndex = 1;
            // 
            // lblPartsCost
            // 
            lblPartsCost.Location = new Point(10, 52);
            lblPartsCost.Name = "lblPartsCost";
            lblPartsCost.Size = new Size(120, 20);
            lblPartsCost.TabIndex = 2;
            lblPartsCost.Text = "零件";
            // 
            // txtPartsCost
            // 
            txtPartsCost.Location = new Point(140, 50);
            txtPartsCost.Name = "txtPartsCost";
            txtPartsCost.ReadOnly = true;
            txtPartsCost.Size = new Size(140, 30);
            txtPartsCost.TabIndex = 3;
            // 
            // lblPartsTax
            // 
            lblPartsTax.Location = new Point(300, 24);
            lblPartsTax.Name = "lblPartsTax";
            lblPartsTax.Size = new Size(120, 20);
            lblPartsTax.TabIndex = 4;
            lblPartsTax.Text = "稅金 (零件)";
            // 
            // txtPartsTax
            // 
            txtPartsTax.Location = new Point(371, 22);
            txtPartsTax.Name = "txtPartsTax";
            txtPartsTax.ReadOnly = true;
            txtPartsTax.Size = new Size(110, 30);
            txtPartsTax.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(300, 52);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(120, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(370, 50);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 30);
            txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(60, 330);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(360, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 403);
            Controls.Add(groupBoxOil);
            Controls.Add(groupBoxCleaning);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxParts);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            groupBoxOil.ResumeLayout(false);
            groupBoxCleaning.ResumeLayout(false);
            groupBoxOther.ResumeLayout(false);
            groupBoxParts.ResumeLayout(false);
            groupBoxParts.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
