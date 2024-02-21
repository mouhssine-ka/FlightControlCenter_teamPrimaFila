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
            tabellaAerei.Location = new Point(14, 101);
            tabellaAerei.Margin = new Padding(3, 4, 3, 4);
            tabellaAerei.MultiSelect = false;
            tabellaAerei.Name = "tabellaAerei";
            tabellaAerei.ReadOnly = true;
            tabellaAerei.RowHeadersWidth = 51;
            tabellaAerei.Size = new Size(887, 468);
            tabellaAerei.TabIndex = 0;
            // 
            // creaAereo
            // 
            creaAereo.Location = new Point(280, 24);
            creaAereo.Margin = new Padding(3, 4, 3, 4);
            creaAereo.Name = "creaAereo";
            creaAereo.Size = new Size(294, 31);
            creaAereo.TabIndex = 7;
            creaAereo.Text = "Aggiungi Aereo";
            creaAereo.UseVisualStyleBackColor = true;
            creaAereo.Click += creaAereo_Click;
            // 
            // aggiornaDati
            // 
            aggiornaDati.Location = new Point(607, 63);
            aggiornaDati.Margin = new Padding(3, 4, 3, 4);
            aggiornaDati.Name = "aggiornaDati";
            aggiornaDati.Size = new Size(294, 31);
            aggiornaDati.TabIndex = 8;
            aggiornaDati.Text = "Aggiorna Flotta";
            aggiornaDati.UseVisualStyleBackColor = true;
            aggiornaDati.Click += button2_Click;
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
            // modificaAereo
            // 
            modificaAereo.Location = new Point(280, 63);
            modificaAereo.Margin = new Padding(3, 4, 3, 4);
            modificaAereo.Name = "modificaAereo";
            modificaAereo.Size = new Size(294, 31);
            modificaAereo.TabIndex = 11;
            modificaAereo.Text = "Modifica Aereo";
            modificaAereo.UseVisualStyleBackColor = true;
            modificaAereo.Click += modificaAereo_Click;
            // 
            // cancellaAereo
            // 
            cancellaAereo.Location = new Point(607, 24);
            cancellaAereo.Margin = new Padding(3, 4, 3, 4);
            cancellaAereo.Name = "cancellaAereo";
            cancellaAereo.Size = new Size(294, 31);
            cancellaAereo.TabIndex = 12;
            cancellaAereo.Text = "Cancella Aereo";
            cancellaAereo.UseVisualStyleBackColor = true;
            cancellaAereo.Click += cancellaAereo_Click;
            // 
            // AirplaneManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cancellaAereo);
            Controls.Add(modificaAereo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(aggiornaDati);
            Controls.Add(creaAereo);
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
        private Button creaAereo;
        private Button aggiornaDati;
        private Label label4;
        private Label label5;
        private Button modificaAereo;
        private Button cancellaAereo;
    }
}
