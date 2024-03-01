namespace FlightSimulatorControlCenter
{
    partial class CreazioneBiglietto
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
            CercaVoloPerBiglietto_button = new Button();
            Annulla_button = new Button();
            CreaBiglietto_button = new Button();
            DatiVolo_label = new Label();
            SuspendLayout();
            // 
            // CercaVoloPerBiglietto_button
            // 
            CercaVoloPerBiglietto_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CercaVoloPerBiglietto_button.Location = new Point(23, 24);
            CercaVoloPerBiglietto_button.Name = "CercaVoloPerBiglietto_button";
            CercaVoloPerBiglietto_button.Size = new Size(199, 64);
            CercaVoloPerBiglietto_button.TabIndex = 9;
            CercaVoloPerBiglietto_button.Text = "Cerca Volo";
            CercaVoloPerBiglietto_button.UseVisualStyleBackColor = true;
            // 
            // Annulla_button
            // 
            Annulla_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Annulla_button.Location = new Point(163, 374);
            Annulla_button.Name = "Annulla_button";
            Annulla_button.Size = new Size(199, 64);
            Annulla_button.TabIndex = 10;
            Annulla_button.Text = "Annulla";
            Annulla_button.UseVisualStyleBackColor = true;
            // 
            // CreaBiglietto_button
            // 
            CreaBiglietto_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreaBiglietto_button.Location = new Point(425, 374);
            CreaBiglietto_button.Name = "CreaBiglietto_button";
            CreaBiglietto_button.Size = new Size(199, 64);
            CreaBiglietto_button.TabIndex = 11;
            CreaBiglietto_button.Text = "Crea Biglietto";
            CreaBiglietto_button.UseVisualStyleBackColor = true;
            // 
            // DatiVolo_label
            // 
            DatiVolo_label.AutoSize = true;
            DatiVolo_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatiVolo_label.Location = new Point(23, 103);
            DatiVolo_label.Name = "DatiVolo_label";
            DatiVolo_label.Size = new Size(129, 28);
            DatiVolo_label.TabIndex = 12;
            DatiVolo_label.Text = "Dati del Volo:";
            // 
            // CreazioneBiglietto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DatiVolo_label);
            Controls.Add(CreaBiglietto_button);
            Controls.Add(Annulla_button);
            Controls.Add(CercaVoloPerBiglietto_button);
            Name = "CreazioneBiglietto";
            Text = "CreazioneBiglietto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CercaVoloPerBiglietto_button;
        private Button Annulla_button;
        private Button CreaBiglietto_button;
        private Label DatiVolo_label;
    }
}