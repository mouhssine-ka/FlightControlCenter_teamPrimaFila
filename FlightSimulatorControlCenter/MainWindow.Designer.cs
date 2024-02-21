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
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fleetToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1138, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fleetToolStripMenuItem
            // 
            fleetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fleetManagerToolStripMenuItem });
            fleetToolStripMenuItem.Name = "fleetToolStripMenuItem";
            fleetToolStripMenuItem.Size = new Size(55, 24);
            fleetToolStripMenuItem.Text = "Fleet";
            fleetToolStripMenuItem.Click += fleetToolStripMenuItem_Click;
            // 
            // fleetManagerToolStripMenuItem
            // 
            fleetManagerToolStripMenuItem.Name = "fleetManagerToolStripMenuItem";
            fleetManagerToolStripMenuItem.Size = new Size(224, 26);
            fleetManagerToolStripMenuItem.Text = "Fleet Manager";
            fleetManagerToolStripMenuItem.Click += fleetManagerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { scelta1ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 24);
            toolStripMenuItem1.Text = "Airplane";
            // 
            // scelta1ToolStripMenuItem
            // 
            scelta1ToolStripMenuItem.Name = "scelta1ToolStripMenuItem";
            scelta1ToolStripMenuItem.Size = new Size(151, 26);
            scelta1ToolStripMenuItem.Text = "Manager";
            scelta1ToolStripMenuItem.Click += airplaneManager_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 696);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
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