namespace FlightSimulatorControlCenter
{
    partial class CancellaAereo
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
            label1 = new Label();
            label2 = new Label();
            idLabelText = new Label();
            label4 = new Label();
            label5 = new Label();
            coloreLabelText = new Label();
            codiceLabelText = new Label();
            numPostiLabelText = new Label();
            label3 = new Label();
            eliminaButton = new Button();
            annullaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 48);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Colore";
            // 
            // idLabelText
            // 
            idLabelText.AutoSize = true;
            idLabelText.Location = new Point(78, 20);
            idLabelText.Name = "idLabelText";
            idLabelText.Size = new Size(68, 15);
            idLabelText.TabIndex = 2;
            idLabelText.Text = "iddainserire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 20);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Codice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 48);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Num. posti";
            // 
            // coloreLabelText
            // 
            coloreLabelText.AutoSize = true;
            coloreLabelText.Location = new Point(78, 48);
            coloreLabelText.Name = "coloreLabelText";
            coloreLabelText.Size = new Size(95, 15);
            coloreLabelText.TabIndex = 5;
            coloreLabelText.Text = "coloredainserirre";
            // 
            // codiceLabelText
            // 
            codiceLabelText.AutoSize = true;
            codiceLabelText.Location = new Point(332, 20);
            codiceLabelText.Name = "codiceLabelText";
            codiceLabelText.Size = new Size(93, 15);
            codiceLabelText.TabIndex = 6;
            codiceLabelText.Text = "codicedainserire";
            // 
            // numPostiLabelText
            // 
            numPostiLabelText.AutoSize = true;
            numPostiLabelText.Location = new Point(336, 48);
            numPostiLabelText.Name = "numPostiLabelText";
            numPostiLabelText.Size = new Size(109, 15);
            numPostiLabelText.TabIndex = 7;
            numPostiLabelText.Text = "numpostidainserire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(421, 30);
            label3.TabIndex = 8;
            label3.Text = "SEI SICURO DI VOLER ELIMINARE I DATI?";
            // 
            // eliminaButton
            // 
            eliminaButton.Location = new Point(21, 178);
            eliminaButton.Name = "eliminaButton";
            eliminaButton.Size = new Size(195, 45);
            eliminaButton.TabIndex = 9;
            eliminaButton.Text = "Elimina";
            eliminaButton.UseVisualStyleBackColor = true;
            eliminaButton.Click += eliminaButton_Click;
            // 
            // annullaButton
            // 
            annullaButton.Location = new Point(270, 178);
            annullaButton.Name = "annullaButton";
            annullaButton.Size = new Size(200, 45);
            annullaButton.TabIndex = 10;
            annullaButton.Text = "Annulla";
            annullaButton.UseVisualStyleBackColor = true;
            annullaButton.Click += annullaButton_Click;
            // 
            // CancellaAereo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 235);
            Controls.Add(annullaButton);
            Controls.Add(eliminaButton);
            Controls.Add(label3);
            Controls.Add(numPostiLabelText);
            Controls.Add(codiceLabelText);
            Controls.Add(coloreLabelText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(idLabelText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CancellaAereo";
            Text = "CancellaAereo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label idLabelText;
        private Label label4;
        private Label label5;
        private Label coloreLabelText;
        private Label codiceLabelText;
        private Label numPostiLabelText;
        private Label label3;
        private Button eliminaButton;
        private Button annullaButton;
    }
}