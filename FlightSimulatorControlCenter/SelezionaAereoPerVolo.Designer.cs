namespace FlightSimulatorControlCenter
{
    partial class SelezionaAereoPerVolo
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
            tabellaAerei = new DataGridView();
            btnAnnulla = new Button();
            btnSeleziona = new Button();
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).BeginInit();
            SuspendLayout();
            // 
            // tabellaAerei
            // 
            tabellaAerei.AllowUserToAddRows = false;
            tabellaAerei.AllowUserToDeleteRows = false;
            tabellaAerei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaAerei.Location = new Point(10, 100);
            tabellaAerei.MultiSelect = false;
            tabellaAerei.Name = "tabellaAerei";
            tabellaAerei.ReadOnly = true;
            tabellaAerei.RowHeadersWidth = 51;
            tabellaAerei.Size = new Size(679, 227);
            tabellaAerei.TabIndex = 2;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnulla.Location = new Point(38, 28);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(134, 42);
            btnAnnulla.TabIndex = 5;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // btnSeleziona
            // 
            btnSeleziona.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleziona.Location = new Point(508, 28);
            btnSeleziona.Name = "btnSeleziona";
            btnSeleziona.Size = new Size(134, 42);
            btnSeleziona.TabIndex = 6;
            btnSeleziona.Text = "Seleziona";
            btnSeleziona.UseVisualStyleBackColor = true;
            btnSeleziona.Click += btnSeleziona_Click;
            // 
            // SelezionaAereoPerVolo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSeleziona);
            Controls.Add(btnAnnulla);
            Controls.Add(tabellaAerei);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelezionaAereoPerVolo";
            Text = "SelezionaAereoPerVolo";
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabellaAerei;
        private Button btnAnnulla;
        private Button btnSeleziona;
    }
}