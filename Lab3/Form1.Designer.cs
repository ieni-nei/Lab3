namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnCalculate = new Button();
            label1 = new Label();
            txtSideA = new TextBox();
            listResult = new ListBox();
            txtSideB = new TextBox();
            label2 = new Label();
            txtAngle = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(187, 261);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(101, 33);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calc";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 73);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Сторона А";
            // 
            // txtSideA
            // 
            txtSideA.Location = new Point(188, 65);
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(100, 23);
            txtSideA.TabIndex = 3;
            // 
            // listResult
            // 
            listResult.FormattingEnabled = true;
            listResult.ItemHeight = 15;
            listResult.Location = new Point(368, 61);
            listResult.Name = "listResult";
            listResult.Size = new Size(250, 139);
            listResult.TabIndex = 4;
            // 
            // txtSideB
            // 
            txtSideB.Location = new Point(188, 116);
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(100, 23);
            txtSideB.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 124);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Сторона В";
            // 
            // txtAngle
            // 
            txtAngle.Location = new Point(188, 177);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(100, 23);
            txtAngle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 185);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Кут між ними";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(45, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 33);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(txtAngle);
            Controls.Add(label3);
            Controls.Add(txtSideB);
            Controls.Add(label2);
            Controls.Add(listResult);
            Controls.Add(txtSideA);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnCalculate;
        private Label label1;
        private TextBox txtSideA;
        private ListBox listResult;
        private TextBox txtSideB;
        private Label label2;
        private TextBox txtAngle;
        private Label label3;
        private Button btnClear;
    }
}
