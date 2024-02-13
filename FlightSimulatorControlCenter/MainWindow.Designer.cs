namespace FlightSimulatorControlCenter
{
    partial class MainWindow
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
            menuStrip1 = new MenuStrip();
            fleetToolStripMenuItem = new ToolStripMenuItem();
            fleetManagerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            scelta1ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fleetToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(996, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fleetToolStripMenuItem
            // 
            fleetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fleetManagerToolStripMenuItem });
            fleetToolStripMenuItem.Name = "fleetToolStripMenuItem";
            fleetToolStripMenuItem.Size = new Size(44, 20);
            fleetToolStripMenuItem.Text = "Fleet";
            // 
            // fleetManagerToolStripMenuItem
            // 
            fleetManagerToolStripMenuItem.Name = "fleetManagerToolStripMenuItem";
            fleetManagerToolStripMenuItem.Size = new Size(149, 22);
            fleetManagerToolStripMenuItem.Text = "Fleet Manager";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { scelta1ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(63, 20);
            toolStripMenuItem1.Text = "Airplane";
            // 
            // scelta1ToolStripMenuItem
            // 
            scelta1ToolStripMenuItem.Name = "scelta1ToolStripMenuItem";
            scelta1ToolStripMenuItem.Size = new Size(121, 22);
            scelta1ToolStripMenuItem.Text = "Manager";
            scelta1ToolStripMenuItem.Click += airplaneManager_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 522);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MainWindow";
            Text = "Flight Simulator Contro Center";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem scelta1ToolStripMenuItem;
        private ToolStripMenuItem fleetToolStripMenuItem;
        private ToolStripMenuItem fleetManagerToolStripMenuItem;
    }
}