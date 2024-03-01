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
            ListaAereiPerVoli_table = new DataGridView();
            Annulla_btn = new Button();
            SelezioneAereo_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaAereiPerVoli_table).BeginInit();
            SuspendLayout();
            // 
            // ListaAereiPerVoli_table
            // 
            ListaAereiPerVoli_table.AllowUserToAddRows = false;
            ListaAereiPerVoli_table.AllowUserToDeleteRows = false;
            ListaAereiPerVoli_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaAereiPerVoli_table.Location = new Point(12, 134);
            ListaAereiPerVoli_table.Margin = new Padding(3, 4, 3, 4);
            ListaAereiPerVoli_table.MultiSelect = false;
            ListaAereiPerVoli_table.Name = "ListaAereiPerVoli_table";
            ListaAereiPerVoli_table.ReadOnly = true;
            ListaAereiPerVoli_table.RowHeadersWidth = 51;
            ListaAereiPerVoli_table.Size = new Size(776, 303);
            ListaAereiPerVoli_table.TabIndex = 2;
            // 
            // Annulla_btn
            // 
            Annulla_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Annulla_btn.Location = new Point(44, 37);
            Annulla_btn.Margin = new Padding(3, 4, 3, 4);
            Annulla_btn.Name = "Annulla_btn";
            Annulla_btn.Size = new Size(153, 56);
            Annulla_btn.TabIndex = 5;
            Annulla_btn.Text = "Annulla";
            Annulla_btn.UseVisualStyleBackColor = true;
            // 
            // SelezioneAereo_btn
            // 
            SelezioneAereo_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelezioneAereo_btn.Location = new Point(581, 37);
            SelezioneAereo_btn.Margin = new Padding(3, 4, 3, 4);
            SelezioneAereo_btn.Name = "SelezioneAereo_btn";
            SelezioneAereo_btn.Size = new Size(153, 56);
            SelezioneAereo_btn.TabIndex = 6;
            SelezioneAereo_btn.Text = "Seleziona";
            SelezioneAereo_btn.UseVisualStyleBackColor = true;
            // 
            // SelezionaAereoPerVolo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelezioneAereo_btn);
            Controls.Add(Annulla_btn);
            Controls.Add(ListaAereiPerVoli_table);
            Name = "SelezionaAereoPerVolo";
            Text = "SelezionaAereoPerVolo";
            ((System.ComponentModel.ISupportInitialize)ListaAereiPerVoli_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListaAereiPerVoli_table;
        private Button Annulla_btn;
        private Button SelezioneAereo_btn;
    }
}