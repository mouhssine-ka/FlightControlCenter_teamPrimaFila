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
            ((System.ComponentModel.ISupportInitialize)tabellaVoli).BeginInit();
            SuspendLayout();
            // 
            // tabellaVoli
            // 
            tabellaVoli.AllowUserToAddRows = false;
            tabellaVoli.AllowUserToDeleteRows = false;
            tabellaVoli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaVoli.Location = new Point(7, 201);
            tabellaVoli.Name = "tabellaVoli";
            tabellaVoli.ReadOnly = true;
            tabellaVoli.Size = new Size(786, 237);
            tabellaVoli.TabIndex = 0;
            // 
            // btnCreaVolo
            // 
            btnCreaVolo.Location = new Point(620, 73);
            btnCreaVolo.Name = "btnCreaVolo";
            btnCreaVolo.Size = new Size(131, 54);
            btnCreaVolo.TabIndex = 1;
            btnCreaVolo.Text = "Crea volo";
            btnCreaVolo.UseVisualStyleBackColor = true;
            btnCreaVolo.Click += btnCreaVolo_Click;
            // 
            // FlightManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
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
    }
}