namespace FlightSimulatorControlCenter
{
    partial class ModificaAereo
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
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            coloreAereoText = new TextBox();
            numPostiText = new TextBox();
            modificaButton = new Button();
            button2 = new Button();
            idAereoLabel = new Label();
            codiceAereoLabel = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 9);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 0;
            label8.Text = "Codice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Id Aereo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Colore:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Num. Posti:";
            // 
            // coloreAereoText
            // 
            coloreAereoText.Location = new Point(81, 40);
            coloreAereoText.Name = "coloreAereoText";
            coloreAereoText.Size = new Size(202, 23);
            coloreAereoText.TabIndex = 4;
            // 
            // numPostiText
            // 
            numPostiText.Location = new Point(81, 73);
            numPostiText.Name = "numPostiText";
            numPostiText.Size = new Size(202, 23);
            numPostiText.TabIndex = 5;
            // 
            // modificaButton
            // 
            modificaButton.Location = new Point(12, 149);
            modificaButton.Name = "modificaButton";
            modificaButton.Size = new Size(174, 49);
            modificaButton.TabIndex = 6;
            modificaButton.Text = "Modifica";
            modificaButton.UseVisualStyleBackColor = true;
            modificaButton.Click += modificaButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 152);
            button2.Name = "button2";
            button2.Size = new Size(187, 46);
            button2.TabIndex = 7;
            button2.Text = "Annulla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // idAereoLabel
            // 
            idAereoLabel.AutoSize = true;
            idAereoLabel.Location = new Point(81, 9);
            idAereoLabel.Name = "idAereoLabel";
            idAereoLabel.Size = new Size(58, 15);
            idAereoLabel.TabIndex = 8;
            idAereoLabel.Text = "quicivalid";
            // 
            // codiceAereoLabel
            // 
            codiceAereoLabel.AutoSize = true;
            codiceAereoLabel.Location = new Point(307, 9);
            codiceAereoLabel.Name = "codiceAereoLabel";
            codiceAereoLabel.Size = new Size(86, 15);
            codiceAereoLabel.TabIndex = 9;
            codiceAereoLabel.Text = "quicivailcodice";
            // 
            // ModificaAereo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 210);
            Controls.Add(codiceAereoLabel);
            Controls.Add(idAereoLabel);
            Controls.Add(button2);
            Controls.Add(modificaButton);
            Controls.Add(numPostiText);
            Controls.Add(coloreAereoText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Name = "ModificaAereo";
            Text = "ModificaAereo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox coloreAereoText;
        private TextBox numPostiText;
        private Button modificaButton;
        private Button button2;
        private Label idAereoLabel;
        private Label codiceAereoLabel;
    }
}