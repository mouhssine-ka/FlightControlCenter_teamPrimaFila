namespace FlightSimulatorControlCenter
{
    partial class FleetManager
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
            tabellaFlotte = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).BeginInit();
            SuspendLayout();
            // 
            // tabellaFlotte
            // 
            tabellaFlotte.AllowUserToAddRows = false;
            tabellaFlotte.AllowUserToDeleteRows = false;
            tabellaFlotte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaFlotte.Location = new Point(12, 170);
            tabellaFlotte.Name = "tabellaFlotte";
            tabellaFlotte.Size = new Size(776, 268);
            tabellaFlotte.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 60);
            button1.Name = "button1";
            button1.Size = new Size(186, 43);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi flotta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(654, 61);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 2;
            button2.Text = "Seleziona";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(654, 109);
            button3.Name = "button3";
            button3.Size = new Size(132, 42);
            button3.TabIndex = 3;
            button3.Text = "Aggiorna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabellaFlotte);
            Name = "FleetManager";
            Text = "FleetManager";
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabellaFlotte;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
    }
}