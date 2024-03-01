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
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(tabellaVoli);
            Name = "FlightForm";
            Text = "FlightForm";
            ((System.ComponentModel.ISupportInitialize)tabellaVoli).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabellaVoli;
    }
}