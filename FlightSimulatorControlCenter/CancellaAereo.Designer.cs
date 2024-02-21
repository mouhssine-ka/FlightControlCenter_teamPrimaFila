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
            Conferma_Btn = new Button();
            Annulla_Btn = new Button();
            label1 = new Label();
            Info_Aereo_lbl = new Label();
            SuspendLayout();
            // 
            // Conferma_Btn
            // 
            Conferma_Btn.Location = new Point(145, 243);
            Conferma_Btn.Name = "Conferma_Btn";
            Conferma_Btn.Size = new Size(168, 73);
            Conferma_Btn.TabIndex = 0;
            Conferma_Btn.Text = "Conferma";
            Conferma_Btn.UseVisualStyleBackColor = true;
            Conferma_Btn.Click += Conferma_Btn_Click;
            // 
            // Annulla_Btn
            // 
            Annulla_Btn.Location = new Point(420, 243);
            Annulla_Btn.Name = "Annulla_Btn";
            Annulla_Btn.Size = new Size(168, 73);
            Annulla_Btn.TabIndex = 1;
            Annulla_Btn.Text = "Annulla";
            Annulla_Btn.UseVisualStyleBackColor = true;
            Annulla_Btn.Click += Annulla_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 60);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 2;
            label1.Text = "Conferma Cancellazione ?";
            // 
            // Info_Aereo_lbl
            // 
            Info_Aereo_lbl.AutoSize = true;
            Info_Aereo_lbl.Location = new Point(161, 133);
            Info_Aereo_lbl.Name = "Info_Aereo_lbl";
            Info_Aereo_lbl.Size = new Size(50, 20);
            Info_Aereo_lbl.TabIndex = 3;
            Info_Aereo_lbl.Text = "label2";
            Info_Aereo_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CancellaAereo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Info_Aereo_lbl);
            Controls.Add(label1);
            Controls.Add(Annulla_Btn);
            Controls.Add(Conferma_Btn);
            Name = "CancellaAereo";
            Text = "CancellaAereo";
            Load += CancellaAereo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Conferma_Btn;
        private Button Annulla_Btn;
        private Label label1;
        private Label Info_Aereo_lbl;
    }
}