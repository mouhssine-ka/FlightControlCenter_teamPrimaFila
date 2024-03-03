namespace FlightSimulatorControlCenter
{
    partial class FlightManager
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
            tabellaVoli = new DataGridView();
            btnCreaVolo = new Button();
            btnEliminaVolo = new Button();
            btnSeleziona = new Button();
            btnModificaVolo = new Button();
            ((System.ComponentModel.ISupportInitialize)tabellaVoli).BeginInit();
            SuspendLayout();
            // 
            // tabellaVoli
            // 
            tabellaVoli.AllowUserToAddRows = false;
            tabellaVoli.AllowUserToDeleteRows = false;
            tabellaVoli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaVoli.Location = new Point(7, 86);
            tabellaVoli.Name = "tabellaVoli";
            tabellaVoli.ReadOnly = true;
            tabellaVoli.Size = new Size(786, 352);
            tabellaVoli.TabIndex = 0;
            // 
            // btnCreaVolo
            // 
            btnCreaVolo.Location = new Point(23, 12);
            btnCreaVolo.Name = "btnCreaVolo";
            btnCreaVolo.Size = new Size(131, 54);
            btnCreaVolo.TabIndex = 1;
            btnCreaVolo.Text = "Crea volo";
            btnCreaVolo.UseVisualStyleBackColor = true;
            btnCreaVolo.Click += btnCreaVolo_Click;
            // 
            // btnEliminaVolo
            // 
            btnEliminaVolo.Location = new Point(662, 12);
            btnEliminaVolo.Name = "btnEliminaVolo";
            btnEliminaVolo.Size = new Size(131, 54);
            btnEliminaVolo.TabIndex = 2;
            btnEliminaVolo.Text = "Elimina";
            btnEliminaVolo.UseVisualStyleBackColor = true;
            btnEliminaVolo.Click += btnEliminaVolo_Click;
            // 
            // btnSeleziona
            // 
            btnSeleziona.Location = new Point(388, 12);
            btnSeleziona.Name = "btnSeleziona";
            btnSeleziona.Size = new Size(131, 54);
            btnSeleziona.TabIndex = 3;
            btnSeleziona.Text = "Seleziona";
            btnSeleziona.UseVisualStyleBackColor = true;
            btnSeleziona.Click += btnSeleziona_Click;
            // 
            // btnModificaVolo
            // 
            btnModificaVolo.Location = new Point(525, 12);
            btnModificaVolo.Name = "btnModificaVolo";
            btnModificaVolo.Size = new Size(131, 54);
            btnModificaVolo.TabIndex = 4;
            btnModificaVolo.Text = "Modifica";
            btnModificaVolo.UseVisualStyleBackColor = true;
            btnModificaVolo.Click += btnModificaVolo_Click;
            // 
            // FlightManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificaVolo);
            Controls.Add(btnSeleziona);
            Controls.Add(btnEliminaVolo);
            Controls.Add(btnCreaVolo);
            Controls.Add(tabellaVoli);
            Name = "FlightManager";
            Text = "FlightForm";
            ((System.ComponentModel.ISupportInitialize)tabellaVoli).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabellaVoli;
        private Button btnCreaVolo;
        private Button btnEliminaVolo;
        private Button btnSeleziona;
        private Button btnModificaVolo;
    }
}