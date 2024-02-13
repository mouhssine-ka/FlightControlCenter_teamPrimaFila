namespace FlightSimulatorControlCenter
{
    partial class Step1Init
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
            tabellaAerei = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            creaAereo = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).BeginInit();
            SuspendLayout();
            // 
            // tabellaAerei
            // 
            tabellaAerei.AllowUserToAddRows = false;
            tabellaAerei.AllowUserToDeleteRows = false;
            tabellaAerei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaAerei.Location = new Point(12, 197);
            tabellaAerei.MultiSelect = false;
            tabellaAerei.Name = "tabellaAerei";
            tabellaAerei.ReadOnly = true;
            tabellaAerei.Size = new Size(776, 230);
            tabellaAerei.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Codice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Colore";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 88);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Numero di posti";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(630, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(630, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 6;
            // 
            // creaAereo
            // 
            creaAereo.Location = new Point(531, 123);
            creaAereo.Name = "creaAereo";
            creaAereo.Size = new Size(257, 23);
            creaAereo.TabIndex = 7;
            creaAereo.Text = "Aggiungi Aereo";
            creaAereo.UseVisualStyleBackColor = true;
            creaAereo.Click += creaAereo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(531, 152);
            button2.Name = "button2";
            button2.Size = new Size(257, 23);
            button2.TabIndex = 8;
            button2.Text = "Aggiorna Flotta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Flotta corrente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 45);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Nome flotta";
            // 
            // Step1Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(creaAereo);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabellaAerei);
            Name = "Step1Init";
            Text = "Form1";
            Load += Step1Init_Load;
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabellaAerei;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button creaAereo;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}
