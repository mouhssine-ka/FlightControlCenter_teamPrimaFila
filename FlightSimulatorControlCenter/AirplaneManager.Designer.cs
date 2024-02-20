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
            creaAereo = new Button();
            aggiornaDati = new Button();
            label4 = new Label();
            label5 = new Label();
            modificaAereo = new Button();
            cancellaAereo = new Button();
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).BeginInit();
            SuspendLayout();
            // 
            // tabellaAerei
            // 
            tabellaAerei.AllowUserToAddRows = false;
            tabellaAerei.AllowUserToDeleteRows = false;
            tabellaAerei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaAerei.Location = new Point(12, 76);
            tabellaAerei.MultiSelect = false;
            tabellaAerei.Name = "tabellaAerei";
            tabellaAerei.ReadOnly = true;
            tabellaAerei.Size = new Size(776, 351);
            tabellaAerei.TabIndex = 0;
            // 
            // creaAereo
            // 
            creaAereo.Location = new Point(245, 18);
            creaAereo.Name = "creaAereo";
            creaAereo.Size = new Size(257, 23);
            creaAereo.TabIndex = 7;
            creaAereo.Text = "Aggiungi Aereo";
            creaAereo.UseVisualStyleBackColor = true;
            creaAereo.Click += creaAereo_Click;
            // 
            // aggiornaDati
            // 
            aggiornaDati.Location = new Point(531, 47);
            aggiornaDati.Name = "aggiornaDati";
            aggiornaDati.Size = new Size(257, 23);
            aggiornaDati.TabIndex = 8;
            aggiornaDati.Text = "Aggiorna Flotta";
            aggiornaDati.UseVisualStyleBackColor = true;
            aggiornaDati.Click += button2_Click;
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
            // modificaAereo
            // 
            modificaAereo.Location = new Point(245, 47);
            modificaAereo.Name = "modificaAereo";
            modificaAereo.Size = new Size(257, 23);
            modificaAereo.TabIndex = 11;
            modificaAereo.Text = "Modifica Aereo";
            modificaAereo.UseVisualStyleBackColor = true;
            // 
            // cancellaAereo
            // 
            cancellaAereo.Location = new Point(531, 18);
            cancellaAereo.Name = "cancellaAereo";
            cancellaAereo.Size = new Size(257, 23);
            cancellaAereo.TabIndex = 12;
            cancellaAereo.Text = "Cancella Aereo";
            cancellaAereo.UseVisualStyleBackColor = true;
            // 
            // AirplaneManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancellaAereo);
            Controls.Add(modificaAereo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(aggiornaDati);
            Controls.Add(creaAereo);
            Controls.Add(tabellaAerei);
            Name = "AirplaneManager";
            Text = "Airplane Manager";
            Load += Step1Init_Load;
            ((System.ComponentModel.ISupportInitialize)tabellaAerei).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabellaAerei;
        private Button creaAereo;
        private Button aggiornaDati;
        private Label label4;
        private Label label5;
        private Button modificaAereo;
        private Button cancellaAereo;
    }
}
