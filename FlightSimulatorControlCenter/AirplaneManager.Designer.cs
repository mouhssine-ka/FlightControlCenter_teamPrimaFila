namespace FlightSimulatorControlCenter
{
    partial class AirplaneManager
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
            txtBoxCodice = new TextBox();
            txtBoxColore = new TextBox();
            txtBoxNumPosti = new TextBox();
            creaAereo = new Button();
            btnAggiornaFlotta = new Button();
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
            tabellaAerei.Location = new Point(14, 263);
            tabellaAerei.Margin = new Padding(3, 4, 3, 4);
            tabellaAerei.MultiSelect = false;
            tabellaAerei.Name = "tabellaAerei";
            tabellaAerei.ReadOnly = true;
            tabellaAerei.RowHeadersWidth = 51;
            tabellaAerei.Size = new Size(887, 307);
            tabellaAerei.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(607, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Codice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 71);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Colore";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 117);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "Numero di posti";
            // 
            // txtBoxCodice
            // 
            txtBoxCodice.Location = new Point(720, 13);
            txtBoxCodice.Margin = new Padding(3, 4, 3, 4);
            txtBoxCodice.Name = "txtBoxCodice";
            txtBoxCodice.Size = new Size(180, 27);
            txtBoxCodice.TabIndex = 4;
            // 
            // txtBoxColore
            // 
            txtBoxColore.Location = new Point(720, 60);
            txtBoxColore.Margin = new Padding(3, 4, 3, 4);
            txtBoxColore.Name = "txtBoxColore";
            txtBoxColore.Size = new Size(180, 27);
            txtBoxColore.TabIndex = 5;
            // 
            // txtBoxNumPosti
            // 
            txtBoxNumPosti.Location = new Point(720, 107);
            txtBoxNumPosti.Margin = new Padding(3, 4, 3, 4);
            txtBoxNumPosti.Name = "txtBoxNumPosti";
            txtBoxNumPosti.Size = new Size(180, 27);
            txtBoxNumPosti.TabIndex = 6;
            // 
            // creaAereo
            // 
            creaAereo.Location = new Point(607, 164);
            creaAereo.Margin = new Padding(3, 4, 3, 4);
            creaAereo.Name = "creaAereo";
            creaAereo.Size = new Size(294, 31);
            creaAereo.TabIndex = 7;
            creaAereo.Text = "Aggiungi Aereo";
            creaAereo.UseVisualStyleBackColor = true;
            creaAereo.Click += creaAereo_Click;
            // 
            // btnAggiornaFlotta
            // 
            btnAggiornaFlotta.Location = new Point(607, 203);
            btnAggiornaFlotta.Margin = new Padding(3, 4, 3, 4);
            btnAggiornaFlotta.Name = "btnAggiornaFlotta";
            btnAggiornaFlotta.Size = new Size(294, 31);
            btnAggiornaFlotta.TabIndex = 8;
            btnAggiornaFlotta.Text = "Aggiorna Flotta";
            btnAggiornaFlotta.UseVisualStyleBackColor = true;
            btnAggiornaFlotta.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 24);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "Flotta corrente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 60);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "Nome flotta";
            // 
            // AirplaneManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAggiornaFlotta);
            Controls.Add(creaAereo);
            Controls.Add(txtBoxNumPosti);
            Controls.Add(txtBoxColore);
            Controls.Add(txtBoxCodice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabellaAerei);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AirplaneManager";
            Text = "Airplane Manager";
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
        private TextBox txtBoxCodice;
        private TextBox txtBoxColore;
        private TextBox txtBoxNumPosti;
        private Button creaAereo;
        private Button btnAggiornaFlotta;
        private Label label4;
        private Label label5;
    }
}
