namespace FlightSimulatorControlCenter
{
    partial class CreazioneVolo
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
            txtBoxCittaArrivo = new TextBox();
            lblCreaVolo = new Label();
            txtBoxCostoVolo = new TextBox();
            txtBoxCittaPartenza = new TextBox();
            btnScegliAereo = new Button();
            lblAereoSelezionato = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCreaVolo = new Button();
            dtpOrarioArrivo = new DateTimePicker();
            dtpOrarioPartenza = new DateTimePicker();
            lblIdAereoSelezoinato = new Label();
            label1 = new Label();
            btnAnnulla = new Button();
            SuspendLayout();
            // 
            // txtBoxCittaArrivo
            // 
            txtBoxCittaArrivo.Location = new Point(315, 169);
            txtBoxCittaArrivo.Name = "txtBoxCittaArrivo";
            txtBoxCittaArrivo.Size = new Size(190, 23);
            txtBoxCittaArrivo.TabIndex = 2;
            // 
            // lblCreaVolo
            // 
            lblCreaVolo.AutoSize = true;
            lblCreaVolo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreaVolo.Location = new Point(289, 18);
            lblCreaVolo.Name = "lblCreaVolo";
            lblCreaVolo.Size = new Size(107, 30);
            lblCreaVolo.TabIndex = 1;
            lblCreaVolo.Text = "Crea Volo";
            // 
            // txtBoxCostoVolo
            // 
            txtBoxCostoVolo.Location = new Point(315, 96);
            txtBoxCostoVolo.Name = "txtBoxCostoVolo";
            txtBoxCostoVolo.Size = new Size(190, 23);
            txtBoxCostoVolo.TabIndex = 0;
            // 
            // txtBoxCittaPartenza
            // 
            txtBoxCittaPartenza.Location = new Point(315, 129);
            txtBoxCittaPartenza.Name = "txtBoxCittaPartenza";
            txtBoxCittaPartenza.Size = new Size(190, 23);
            txtBoxCittaPartenza.TabIndex = 1;
            // 
            // btnScegliAereo
            // 
            btnScegliAereo.Location = new Point(42, 152);
            btnScegliAereo.Name = "btnScegliAereo";
            btnScegliAereo.Size = new Size(105, 35);
            btnScegliAereo.TabIndex = 6;
            btnScegliAereo.Text = "Scegli Aereo";
            btnScegliAereo.UseVisualStyleBackColor = true;
            btnScegliAereo.Click += btnScegliAereo_Click;
            // 
            // lblAereoSelezionato
            // 
            lblAereoSelezionato.AutoSize = true;
            lblAereoSelezionato.Location = new Point(34, 207);
            lblAereoSelezionato.Name = "lblAereoSelezionato";
            lblAereoSelezionato.Size = new Size(107, 15);
            lblAereoSelezionato.TabIndex = 8;
            lblAereoSelezionato.Text = "Aereo Selezionato: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 98);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "Costo Posto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 207);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 10;
            label3.Text = "Orario Partenza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 172);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Città Arrivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 132);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 12;
            label5.Text = "Città Partenza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 247);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 14;
            label6.Text = "Orario Arrivo";
            // 
            // btnCreaVolo
            // 
            btnCreaVolo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreaVolo.Location = new Point(546, 153);
            btnCreaVolo.Name = "btnCreaVolo";
            btnCreaVolo.Size = new Size(105, 35);
            btnCreaVolo.TabIndex = 7;
            btnCreaVolo.Text = "Salva";
            btnCreaVolo.UseVisualStyleBackColor = true;
            btnCreaVolo.Click += btnCreaVolo_Click;
            // 
            // dtpOrarioArrivo
            // 
            dtpOrarioArrivo.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpOrarioArrivo.Format = DateTimePickerFormat.Custom;
            dtpOrarioArrivo.Location = new Point(315, 247);
            dtpOrarioArrivo.Name = "dtpOrarioArrivo";
            dtpOrarioArrivo.Size = new Size(191, 23);
            dtpOrarioArrivo.TabIndex = 5;
            // 
            // dtpOrarioPartenza
            // 
            dtpOrarioPartenza.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpOrarioPartenza.Format = DateTimePickerFormat.Custom;
            dtpOrarioPartenza.ImeMode = ImeMode.NoControl;
            dtpOrarioPartenza.Location = new Point(314, 207);
            dtpOrarioPartenza.Name = "dtpOrarioPartenza";
            dtpOrarioPartenza.Size = new Size(192, 23);
            dtpOrarioPartenza.TabIndex = 4;
            // 
            // lblIdAereoSelezoinato
            // 
            lblIdAereoSelezoinato.AutoSize = true;
            lblIdAereoSelezoinato.Location = new Point(141, 207);
            lblIdAereoSelezoinato.Name = "lblIdAereoSelezoinato";
            lblIdAereoSelezoinato.Size = new Size(18, 15);
            lblIdAereoSelezoinato.TabIndex = 18;
            lblIdAereoSelezoinato.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(340, 300);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 19;
            // 
            // btnAnnulla
            // 
            btnAnnulla.BackColor = Color.Red;
            btnAnnulla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnulla.ForeColor = Color.White;
            btnAnnulla.Location = new Point(305, 288);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(82, 29);
            btnAnnulla.TabIndex = 20;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = false;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // CreazioneVolo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAnnulla);
            Controls.Add(label1);
            Controls.Add(lblIdAereoSelezoinato);
            Controls.Add(dtpOrarioPartenza);
            Controls.Add(dtpOrarioArrivo);
            Controls.Add(btnCreaVolo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblAereoSelezionato);
            Controls.Add(btnScegliAereo);
            Controls.Add(txtBoxCittaPartenza);
            Controls.Add(txtBoxCostoVolo);
            Controls.Add(lblCreaVolo);
            Controls.Add(txtBoxCittaArrivo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreazioneVolo";
            Text = "CreazionVolo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxCittaArrivo;
        private Label lblCreaVolo;
        private TextBox txtBoxCostoVolo;
        private TextBox txtBoxCittaPartenza;
        private Button btnScegliAereo;
        private Label lblAereoSelezionato;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCreaVolo;
        private DateTimePicker dtpOrarioArrivo;
        private DateTimePicker dtpOrarioPartenza;
        private Label lblIdAereoSelezoinato;
        private Label label1;
        private Button btnAnnulla;
    }
}