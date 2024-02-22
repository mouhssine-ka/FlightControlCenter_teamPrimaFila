namespace FlightSimulatorControlCenter
{
    partial class FleetManager
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
            tabellaFlotte = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).BeginInit();
            SuspendLayout();
            // 
            // tabellaFlotte
            // 
            tabellaFlotte.AllowUserToAddRows = false;
            tabellaFlotte.AllowUserToDeleteRows = false;
            tabellaFlotte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaFlotte.Location = new Point(14, 103);
            tabellaFlotte.Margin = new Padding(3, 4, 3, 4);
            tabellaFlotte.Name = "tabellaFlotte";
            tabellaFlotte.RowHeadersWidth = 51;
            tabellaFlotte.Size = new Size(887, 481);
            tabellaFlotte.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(14, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(213, 57);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi flotta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(590, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(153, 56);
            button2.TabIndex = 2;
            button2.Text = "Seleziona";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(750, 16);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(151, 56);
            button3.TabIndex = 3;
            button3.Text = "Aggiorna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabellaFlotte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FleetManager";
            Text = "FleetManager";
            Load += FleetManager_Load;
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabellaFlotte;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}