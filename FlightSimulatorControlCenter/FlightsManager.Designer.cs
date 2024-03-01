namespace FlightSimulatorControlCenter
{
    partial class FlightsManager
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
            CreateVolo_Btn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CreateVolo_Btn
            // 
            CreateVolo_Btn.BackColor = Color.LightBlue;
            CreateVolo_Btn.BackgroundImageLayout = ImageLayout.None;
            CreateVolo_Btn.Location = new Point(648, 36);
            CreateVolo_Btn.Name = "CreateVolo_Btn";
            CreateVolo_Btn.Size = new Size(121, 74);
            CreateVolo_Btn.TabIndex = 0;
            CreateVolo_Btn.Text = "Crea Volo";
            CreateVolo_Btn.UseVisualStyleBackColor = false;
            CreateVolo_Btn.Click += CreateVolo_Btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 174);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FlightsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(CreateVolo_Btn);
            Name = "FlightsManager";
            Text = "FlightsManager";
            Load += FlightsManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateVolo_Btn;
        private DataGridView dataGridView1;
    }
}