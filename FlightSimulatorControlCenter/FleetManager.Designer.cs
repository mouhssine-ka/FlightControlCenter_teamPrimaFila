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
            selezionaFlotta = new Button();
            button3 = new Button();
            txtBox_NomeFlotta = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).BeginInit();
            SuspendLayout();
            // 
            // tabellaFlotte
            // 
            tabellaFlotte.AllowUserToAddRows = false;
            tabellaFlotte.AllowUserToDeleteRows = false;
            tabellaFlotte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabellaFlotte.Location = new Point(14, 227);
            tabellaFlotte.Margin = new Padding(3, 4, 3, 4);
            tabellaFlotte.Name = "tabellaFlotte";
            tabellaFlotte.RowHeadersWidth = 51;
            tabellaFlotte.Size = new Size(887, 357);
            tabellaFlotte.TabIndex = 0;
            tabellaFlotte.CellContentClick += tabellaFlotte_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(341, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 57);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // selezionaFlotta
            // 
            selezionaFlotta.Location = new Point(747, 81);
            selezionaFlotta.Margin = new Padding(3, 4, 3, 4);
            selezionaFlotta.Name = "selezionaFlotta";
            selezionaFlotta.Size = new Size(153, 56);
            selezionaFlotta.TabIndex = 2;
            selezionaFlotta.Text = "Seleziona";
            selezionaFlotta.UseVisualStyleBackColor = true;
            selezionaFlotta.Click += selezionaFlotta_Click;
            // 
            // button3
            // 
            button3.Location = new Point(747, 145);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(151, 56);
            button3.TabIndex = 3;
            button3.Text = "Aggiorna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBox_NomeFlotta
            // 
            txtBox_NomeFlotta.Location = new Point(161, 16);
            txtBox_NomeFlotta.Name = "txtBox_NomeFlotta";
            txtBox_NomeFlotta.Size = new Size(125, 27);
            txtBox_NomeFlotta.TabIndex = 4;
            txtBox_NomeFlotta.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome Flotta";
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txtBox_NomeFlotta);
            Controls.Add(button3);
            Controls.Add(selezionaFlotta);
            Controls.Add(button1);
            Controls.Add(tabellaFlotte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FleetManager";
            Text = "FleetManager";
            ((System.ComponentModel.ISupportInitialize)tabellaFlotte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabellaFlotte;
        private Button button1;
        private Button selezionaFlotta;
        private Button button3;
        private TextBox txtBox_NomeFlotta;
        private Label label1;
    }
}