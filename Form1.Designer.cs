
namespace Game_of_Life
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRandomSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWindowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGridLineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit1010GridLineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLivingCellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUniverseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolstripClearButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripPlayButton = new System.Windows.Forms.ToolStripButton();
            this.toolstripPauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolstripNextButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleHUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setSeedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.setUniverseSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleUniverseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileClear,
            this.toolStripSeparator1,
            this.menuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(219, 22);
            this.menuFileNew.Text = "&Draw New Universe";
            this.menuFileNew.ToolTipText = "Create New Universe from Current Seed";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileClear
            // 
            this.menuFileClear.Name = "menuFileClear";
            this.menuFileClear.Size = new System.Drawing.Size(219, 22);
            this.menuFileClear.Text = "&Clear Universe";
            this.menuFileClear.Click += new System.EventHandler(this.menuFileClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(219, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.CheckOnClick = true;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toggleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.toolsToolStripMenuItem.Text = "&Toggle";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Checked = true;
            this.customizeToolStripMenuItem.CheckOnClick = true;
            this.customizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.customizeToolStripMenuItem.Text = "Toggle &Grid";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Checked = true;
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.optionsToolStripMenuItem.Text = "Toggle &Neighbor Count";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Checked = true;
            this.toggleToolStripMenuItem.CheckOnClick = true;
            this.toggleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.toggleToolStripMenuItem.Text = "Toggle &Heads up";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRandomSeedToolStripMenuItem,
            this.editWindowSizeToolStripMenuItem,
            this.personalizationToolStripMenuItem,
            this.changeUniverseTypeToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.functionsToolStripMenuItem.Text = "Settings";
            // 
            // editRandomSeedToolStripMenuItem
            // 
            this.editRandomSeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSeedToolStripMenuItem,
            this.randomizeUniverseToolStripMenuItem});
            this.editRandomSeedToolStripMenuItem.Name = "editRandomSeedToolStripMenuItem";
            this.editRandomSeedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editRandomSeedToolStripMenuItem.Text = "Randomize";
            // 
            // setSeedToolStripMenuItem
            // 
            this.setSeedToolStripMenuItem.Name = "setSeedToolStripMenuItem";
            this.setSeedToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.setSeedToolStripMenuItem.Text = "Set Seed";
            this.setSeedToolStripMenuItem.Click += new System.EventHandler(this.setSeedToolStripMenuItem_Click);
            // 
            // randomizeUniverseToolStripMenuItem
            // 
            this.randomizeUniverseToolStripMenuItem.Name = "randomizeUniverseToolStripMenuItem";
            this.randomizeUniverseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.randomizeUniverseToolStripMenuItem.Text = "Randomize from Time";
            this.randomizeUniverseToolStripMenuItem.Click += new System.EventHandler(this.randomizeUniverseToolStripMenuItem_Click);
            // 
            // editWindowSizeToolStripMenuItem
            // 
            this.editWindowSizeToolStripMenuItem.Name = "editWindowSizeToolStripMenuItem";
            this.editWindowSizeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editWindowSizeToolStripMenuItem.Text = "Edit Universe Size";
            this.editWindowSizeToolStripMenuItem.Click += new System.EventHandler(this.editWindowSizeToolStripMenuItem_Click);
            // 
            // personalizationToolStripMenuItem
            // 
            this.personalizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBackgroundColorToolStripMenuItem,
            this.editGridLineColorToolStripMenuItem,
            this.edit1010GridLineColorToolStripMenuItem,
            this.editLivingCellColorToolStripMenuItem});
            this.personalizationToolStripMenuItem.Name = "personalizationToolStripMenuItem";
            this.personalizationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.personalizationToolStripMenuItem.Text = "Personalization";
            // 
            // editBackgroundColorToolStripMenuItem
            // 
            this.editBackgroundColorToolStripMenuItem.Name = "editBackgroundColorToolStripMenuItem";
            this.editBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editBackgroundColorToolStripMenuItem.Text = "Edit Background Color";
            this.editBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.editBackgroundColorToolStripMenuItem_Click);
            // 
            // editGridLineColorToolStripMenuItem
            // 
            this.editGridLineColorToolStripMenuItem.Name = "editGridLineColorToolStripMenuItem";
            this.editGridLineColorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editGridLineColorToolStripMenuItem.Text = "Edit Grid Line Color";
            this.editGridLineColorToolStripMenuItem.Click += new System.EventHandler(this.editGridLineColorToolStripMenuItem_Click);
            // 
            // edit1010GridLineColorToolStripMenuItem
            // 
            this.edit1010GridLineColorToolStripMenuItem.Name = "edit1010GridLineColorToolStripMenuItem";
            this.edit1010GridLineColorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.edit1010GridLineColorToolStripMenuItem.Text = "Edit 10*10 Grid  Line Color";
            this.edit1010GridLineColorToolStripMenuItem.Click += new System.EventHandler(this.edit1010GridLineColorToolStripMenuItem_Click);
            // 
            // editLivingCellColorToolStripMenuItem
            // 
            this.editLivingCellColorToolStripMenuItem.Name = "editLivingCellColorToolStripMenuItem";
            this.editLivingCellColorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editLivingCellColorToolStripMenuItem.Text = "Edit Living Cell Color";
            this.editLivingCellColorToolStripMenuItem.Click += new System.EventHandler(this.editLivingCellColorToolStripMenuItem_Click);
            // 
            // changeUniverseTypeToolStripMenuItem
            // 
            this.changeUniverseTypeToolStripMenuItem.Name = "changeUniverseTypeToolStripMenuItem";
            this.changeUniverseTypeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.changeUniverseTypeToolStripMenuItem.Text = "Change Universe Type";
            this.changeUniverseTypeToolStripMenuItem.ToolTipText = "Toggle between finite and torodial universe types";
            this.changeUniverseTypeToolStripMenuItem.Click += new System.EventHandler(this.changeUniverseTypeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripNewButton,
            this.toolstripClearButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolstripPlayButton,
            this.toolstripPauseButton,
            this.toolstripNextButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(753, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripNewButton
            // 
            this.toolstripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripNewButton.Image")));
            this.toolstripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripNewButton.Name = "toolstripNewButton";
            this.toolstripNewButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripNewButton.Text = "&Draw New Universe";
            this.toolstripNewButton.ToolTipText = "Create New Universe from Current Seed";
            this.toolstripNewButton.Click += new System.EventHandler(this.toolstripNewButton_Click);
            // 
            // toolstripClearButton
            // 
            this.toolstripClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripClearButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripClearButton.Image")));
            this.toolstripClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripClearButton.Name = "toolstripClearButton";
            this.toolstripClearButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripClearButton.Text = "Clear";
            this.toolstripClearButton.ToolTipText = "Clear Universe";
            this.toolstripClearButton.Click += new System.EventHandler(this.toolstripClearButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstripPlayButton
            // 
            this.toolstripPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPlayButton.Image")));
            this.toolstripPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPlayButton.Name = "toolstripPlayButton";
            this.toolstripPlayButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripPlayButton.Text = "Play";
            this.toolstripPlayButton.Click += new System.EventHandler(this.toolstripPlayButton_Click);
            // 
            // toolstripPauseButton
            // 
            this.toolstripPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPauseButton.Image")));
            this.toolstripPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPauseButton.Name = "toolstripPauseButton";
            this.toolstripPauseButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripPauseButton.Text = "Pause";
            this.toolstripPauseButton.Click += new System.EventHandler(this.toolstripPauseButton_Click);
            // 
            // toolstripNextButton
            // 
            this.toolstripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripNextButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripNextButton.Image")));
            this.toolstripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripNextButton.Name = "toolstripNextButton";
            this.toolstripNextButton.Size = new System.Drawing.Size(23, 22);
            this.toolstripNextButton.Text = "Next";
            this.toolstripNextButton.Click += new System.EventHandler(this.toolstripNextButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabel1,
            this.toolStripStatusLivingCells});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLivingCells
            // 
            this.toolStripStatusLivingCells.Name = "toolStripStatusLivingCells";
            this.toolStripStatusLivingCells.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLivingCells.Text = "Living Cells = 0";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(753, 486);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleGridToolStripMenuItem1,
            this.toggleNeighborCountToolStripMenuItem,
            this.toggleHUDToolStripMenuItem,
            this.toolStripSeparator2,
            this.setSeedToolStripMenuItem2,
            this.setUniverseSizeToolStripMenuItem,
            this.toggleUniverseTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 164);
            // 
            // toggleGridToolStripMenuItem1
            // 
            this.toggleGridToolStripMenuItem1.Name = "toggleGridToolStripMenuItem1";
            this.toggleGridToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.toggleGridToolStripMenuItem1.Text = "Toggle Grid";
            this.toggleGridToolStripMenuItem1.Click += new System.EventHandler(this.toggleGridToolStripMenuItem1_Click);
            // 
            // toggleNeighborCountToolStripMenuItem
            // 
            this.toggleNeighborCountToolStripMenuItem.Name = "toggleNeighborCountToolStripMenuItem";
            this.toggleNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.toggleNeighborCountToolStripMenuItem.Text = "Toggle Neighbor Count";
            this.toggleNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.toggleNeighborCountToolStripMenuItem_Click);
            // 
            // toggleHUDToolStripMenuItem
            // 
            this.toggleHUDToolStripMenuItem.Name = "toggleHUDToolStripMenuItem";
            this.toggleHUDToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.toggleHUDToolStripMenuItem.Text = "Toggle HUD";
            this.toggleHUDToolStripMenuItem.Click += new System.EventHandler(this.toggleHUDToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // setSeedToolStripMenuItem2
            // 
            this.setSeedToolStripMenuItem2.Name = "setSeedToolStripMenuItem2";
            this.setSeedToolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
            this.setSeedToolStripMenuItem2.Text = "Set Seed";
            this.setSeedToolStripMenuItem2.Click += new System.EventHandler(this.setSeedToolStripMenuItem2_Click);
            // 
            // setUniverseSizeToolStripMenuItem
            // 
            this.setUniverseSizeToolStripMenuItem.Name = "setUniverseSizeToolStripMenuItem";
            this.setUniverseSizeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.setUniverseSizeToolStripMenuItem.Text = "Set Universe Size";
            this.setUniverseSizeToolStripMenuItem.Click += new System.EventHandler(this.setUniverseSizeToolStripMenuItem_Click);
            // 
            // toggleUniverseTypeToolStripMenuItem
            // 
            this.toggleUniverseTypeToolStripMenuItem.Name = "toggleUniverseTypeToolStripMenuItem";
            this.toggleUniverseTypeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.toggleUniverseTypeToolStripMenuItem.Text = "Toggle Universe Type";
            this.toggleUniverseTypeToolStripMenuItem.Click += new System.EventHandler(this.toggleUniverseTypeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 557);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolstripNewButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolstripPlayButton;
        private System.Windows.Forms.ToolStripButton toolstripPauseButton;
        private System.Windows.Forms.ToolStripButton toolstripNextButton;
        private System.Windows.Forms.ToolStripMenuItem menuFileClear;
        private System.Windows.Forms.ToolStripButton toolstripClearButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLivingCells;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRandomSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWindowSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGridLineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit1010GridLineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLivingCellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUniverseTypeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toggleGridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toggleNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleHUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setSeedToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem setUniverseSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleUniverseTypeToolStripMenuItem;
    }
}

