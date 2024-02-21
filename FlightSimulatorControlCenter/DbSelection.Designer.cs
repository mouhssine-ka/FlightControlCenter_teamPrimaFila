namespace FlightSimulatorControlCenter
{
    partial class DbSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MockedDB = new Button();
            FakeDB = new Button();
            dbEsterno = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // MockedDB
            // 
            MockedDB.Font = new Font("Segoe UI", 13F);
            MockedDB.Location = new Point(533, 343);
            MockedDB.Name = "MockedDB";
            MockedDB.Size = new Size(202, 73);
            MockedDB.TabIndex = 0;
            MockedDB.Text = "MockedDB";
            MockedDB.UseVisualStyleBackColor = true;
            MockedDB.Click += MockedDB_Click;
            // 
            // FakeDB
            // 
            FakeDB.Font = new Font("Segoe UI", 13F);
            FakeDB.Location = new Point(298, 343);
            FakeDB.Name = "FakeDB";
            FakeDB.Size = new Size(202, 73);
            FakeDB.TabIndex = 1;
            FakeDB.Text = "FakeDB";
            FakeDB.UseVisualStyleBackColor = true;
            FakeDB.Click += FakeDB_Click;
            // 
            // dbEsterno
            // 
            dbEsterno.Font = new Font("Segoe UI", 13F);
            dbEsterno.Location = new Point(62, 343);
            dbEsterno.Name = "dbEsterno";
            dbEsterno.Size = new Size(202, 73);
            dbEsterno.TabIndex = 2;
            dbEsterno.Text = "Database esterno";
            dbEsterno.UseVisualStyleBackColor = true;
            dbEsterno.Click += dbEsterno_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 18F);
            textBox1.Location = new Point(229, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 48);
            textBox1.TabIndex = 3;
            textBox1.Text = "Seleziona un Database";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DbSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dbEsterno);
            Controls.Add(FakeDB);
            Controls.Add(MockedDB);
            Name = "DbSelection";
            Text = "DbSelection";
            Load += DbSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MockedDB;
        private Button FakeDB;
        private Button dbEsterno;
        private TextBox textBox1;
    }
}