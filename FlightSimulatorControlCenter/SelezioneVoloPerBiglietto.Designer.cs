namespace FlightSimulatorControlCenter
{
    partial class SelezioneVoloPerBiglietto
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
            ListaAereiPerBiglietto_table = new DataGridView();
            SelezioneVolo_button = new Button();
            Annulla_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaAereiPerBiglietto_table).BeginInit();
            SuspendLayout();
            // 
            // ListaAereiPerBiglietto_table
            // 
            ListaAereiPerBiglietto_table.AllowUserToAddRows = false;
            ListaAereiPerBiglietto_table.AllowUserToDeleteRows = false;
            ListaAereiPerBiglietto_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaAereiPerBiglietto_table.Location = new Point(12, 134);
            ListaAereiPerBiglietto_table.Margin = new Padding(3, 4, 3, 4);
            ListaAereiPerBiglietto_table.MultiSelect = false;
            ListaAereiPerBiglietto_table.Name = "ListaAereiPerBiglietto_table";
            ListaAereiPerBiglietto_table.ReadOnly = true;
            ListaAereiPerBiglietto_table.RowHeadersWidth = 51;
            ListaAereiPerBiglietto_table.Size = new Size(776, 303);
            ListaAereiPerBiglietto_table.TabIndex = 1;
            // 
            // SelezioneVolo_button
            // 
            SelezioneVolo_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelezioneVolo_button.Location = new Point(603, 42);
            SelezioneVolo_button.Margin = new Padding(3, 4, 3, 4);
            SelezioneVolo_button.Name = "SelezioneVolo_button";
            SelezioneVolo_button.Size = new Size(153, 56);
            SelezioneVolo_button.TabIndex = 3;
            SelezioneVolo_button.Text = "Seleziona";
            SelezioneVolo_button.UseVisualStyleBackColor = true;
            // 
            // Annulla_button
            // 
            Annulla_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Annulla_button.Location = new Point(38, 42);
            Annulla_button.Margin = new Padding(3, 4, 3, 4);
            Annulla_button.Name = "Annulla_button";
            Annulla_button.Size = new Size(153, 56);
            Annulla_button.TabIndex = 4;
            Annulla_button.Text = "Annulla";
            Annulla_button.UseVisualStyleBackColor = true;
            // 
            // SelezioneAereoPerBiglietto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Annulla_button);
            Controls.Add(SelezioneVolo_button);
            Controls.Add(ListaAereiPerBiglietto_table);
            Name = "SelezioneAereoPerBiglietto";
            Text = "SelezioneAereoPerBiglietto";
            ((System.ComponentModel.ISupportInitialize)ListaAereiPerBiglietto_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListaAereiPerBiglietto_table;
        private Button SelezioneVolo_button;
        private Button Annulla_button;
    }
}