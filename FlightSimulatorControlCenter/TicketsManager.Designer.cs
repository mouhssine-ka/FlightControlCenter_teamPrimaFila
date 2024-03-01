namespace FlightSimulatorControlCenter
{
    partial class TicketsManager
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
            dataGridView1 = new DataGridView();
            Ticket_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 261);
            dataGridView1.TabIndex = 0;
            // 
            // Ticket_button
            // 
            Ticket_button.Location = new Point(629, 27);
            Ticket_button.Name = "Ticket_button";
            Ticket_button.Size = new Size(159, 36);
            Ticket_button.TabIndex = 1;
            Ticket_button.Text = "Crea Biglietto";
            Ticket_button.UseVisualStyleBackColor = true;
            Ticket_button.Click += Ticket_button_Click;
            // 
            // TicketsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ticket_button);
            Controls.Add(dataGridView1);
            Name = "TicketsManager";
            Text = "TicketsManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Ticket_button;
    }
}