namespace automatedMarkingApp
{
    partial class frmMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMark));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterIfBlueInkWasUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterIfGreenInkWasUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterIfRedInkWasUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertTemplateOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertFormOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterTemplateOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFormOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueInkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenInkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redInkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeExcessNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markFormAndRetainTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeImage640x590PixelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateAndFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateAsBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFormAsBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndSaveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblXY = new System.Windows.Forms.Label();
            this.lblARGB = new System.Windows.Forms.Label();
            this.lblWH = new System.Windows.Forms.Label();
            this.formPb = new System.Windows.Forms.PictureBox();
            this.templatePb = new System.Windows.Forms.PictureBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.templateAndFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.templateOnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formOnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatePb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.markToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateToolStripMenuItem,
            this.openFormToolStripMenuItem,
            this.saveTemplateToolStripMenuItem,
            this.saveFormToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openTemplateToolStripMenuItem.Text = "Open Template";
            this.openTemplateToolStripMenuItem.Click += new System.EventHandler(this.openTemplateToolStripMenuItem_Click);
            // 
            // openFormToolStripMenuItem
            // 
            this.openFormToolStripMenuItem.Name = "openFormToolStripMenuItem";
            this.openFormToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openFormToolStripMenuItem.Text = "Open Form";
            this.openFormToolStripMenuItem.Click += new System.EventHandler(this.openFormToolStripMenuItem_Click);
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            this.saveTemplateToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateToolStripMenuItem_Click);
            // 
            // saveFormToolStripMenuItem
            // 
            this.saveFormToolStripMenuItem.Name = "saveFormToolStripMenuItem";
            this.saveFormToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveFormToolStripMenuItem.Text = "Save Form";
            this.saveFormToolStripMenuItem.Click += new System.EventHandler(this.saveFormToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.filterIfBlueInkWasUsedToolStripMenuItem,
            this.filterIfGreenInkWasUsedToolStripMenuItem,
            this.filterIfRedInkWasUsedToolStripMenuItem,
            this.invertTemplateOnlyToolStripMenuItem,
            this.invertFormOnlyToolStripMenuItem,
            this.filterTemplateOnlyToolStripMenuItem,
            this.filterFormOnlyToolStripMenuItem,
            this.removeExcessNoiseToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // filterIfBlueInkWasUsedToolStripMenuItem
            // 
            this.filterIfBlueInkWasUsedToolStripMenuItem.Name = "filterIfBlueInkWasUsedToolStripMenuItem";
            this.filterIfBlueInkWasUsedToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterIfBlueInkWasUsedToolStripMenuItem.Text = "Filter if blue ink was used";
            this.filterIfBlueInkWasUsedToolStripMenuItem.Click += new System.EventHandler(this.filterIfBlueInkWasUsedToolStripMenuItem_Click);
            // 
            // filterIfGreenInkWasUsedToolStripMenuItem
            // 
            this.filterIfGreenInkWasUsedToolStripMenuItem.Name = "filterIfGreenInkWasUsedToolStripMenuItem";
            this.filterIfGreenInkWasUsedToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterIfGreenInkWasUsedToolStripMenuItem.Text = "Filter if green ink was used";
            this.filterIfGreenInkWasUsedToolStripMenuItem.Click += new System.EventHandler(this.filterIfGreenInkWasUsedToolStripMenuItem_Click);
            // 
            // filterIfRedInkWasUsedToolStripMenuItem
            // 
            this.filterIfRedInkWasUsedToolStripMenuItem.Name = "filterIfRedInkWasUsedToolStripMenuItem";
            this.filterIfRedInkWasUsedToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterIfRedInkWasUsedToolStripMenuItem.Text = "Filter if red ink was used";
            this.filterIfRedInkWasUsedToolStripMenuItem.Click += new System.EventHandler(this.filterIfRedInkWasUsedToolStripMenuItem_Click);
            // 
            // invertTemplateOnlyToolStripMenuItem
            // 
            this.invertTemplateOnlyToolStripMenuItem.Name = "invertTemplateOnlyToolStripMenuItem";
            this.invertTemplateOnlyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.invertTemplateOnlyToolStripMenuItem.Text = "Invert Template only";
            this.invertTemplateOnlyToolStripMenuItem.Click += new System.EventHandler(this.invertTemplateOnlyToolStripMenuItem_Click);
            // 
            // invertFormOnlyToolStripMenuItem
            // 
            this.invertFormOnlyToolStripMenuItem.Name = "invertFormOnlyToolStripMenuItem";
            this.invertFormOnlyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.invertFormOnlyToolStripMenuItem.Text = "Invert Form only";
            this.invertFormOnlyToolStripMenuItem.Click += new System.EventHandler(this.invertFormOnlyToolStripMenuItem_Click);
            // 
            // filterTemplateOnlyToolStripMenuItem
            // 
            this.filterTemplateOnlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueInkToolStripMenuItem,
            this.greenInkToolStripMenuItem,
            this.redInkToolStripMenuItem});
            this.filterTemplateOnlyToolStripMenuItem.Name = "filterTemplateOnlyToolStripMenuItem";
            this.filterTemplateOnlyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterTemplateOnlyToolStripMenuItem.Text = "Filter Template only";
            // 
            // blueInkToolStripMenuItem
            // 
            this.blueInkToolStripMenuItem.Name = "blueInkToolStripMenuItem";
            this.blueInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.blueInkToolStripMenuItem.Text = "Blue Ink";
            this.blueInkToolStripMenuItem.Click += new System.EventHandler(this.blueInkToolStripMenuItem_Click);
            // 
            // greenInkToolStripMenuItem
            // 
            this.greenInkToolStripMenuItem.Name = "greenInkToolStripMenuItem";
            this.greenInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.greenInkToolStripMenuItem.Text = "Green Ink";
            this.greenInkToolStripMenuItem.Click += new System.EventHandler(this.greenInkToolStripMenuItem_Click);
            // 
            // redInkToolStripMenuItem
            // 
            this.redInkToolStripMenuItem.Name = "redInkToolStripMenuItem";
            this.redInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.redInkToolStripMenuItem.Text = "Red Ink";
            this.redInkToolStripMenuItem.Click += new System.EventHandler(this.redInkToolStripMenuItem_Click);
            // 
            // filterFormOnlyToolStripMenuItem
            // 
            this.filterFormOnlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueInkToolStripMenuItem1,
            this.greenInkToolStripMenuItem1,
            this.redInkToolStripMenuItem1});
            this.filterFormOnlyToolStripMenuItem.Name = "filterFormOnlyToolStripMenuItem";
            this.filterFormOnlyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterFormOnlyToolStripMenuItem.Text = "Filter Form only";
            // 
            // blueInkToolStripMenuItem1
            // 
            this.blueInkToolStripMenuItem1.Name = "blueInkToolStripMenuItem1";
            this.blueInkToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.blueInkToolStripMenuItem1.Text = "Blue Ink";
            this.blueInkToolStripMenuItem1.Click += new System.EventHandler(this.blueInkToolStripMenuItem1_Click);
            // 
            // greenInkToolStripMenuItem1
            // 
            this.greenInkToolStripMenuItem1.Name = "greenInkToolStripMenuItem1";
            this.greenInkToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.greenInkToolStripMenuItem1.Text = "Green Ink";
            this.greenInkToolStripMenuItem1.Click += new System.EventHandler(this.greenInkToolStripMenuItem1_Click);
            // 
            // redInkToolStripMenuItem1
            // 
            this.redInkToolStripMenuItem1.Name = "redInkToolStripMenuItem1";
            this.redInkToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.redInkToolStripMenuItem1.Text = "Red Ink";
            this.redInkToolStripMenuItem1.Click += new System.EventHandler(this.redInkToolStripMenuItem1_Click);
            // 
            // removeExcessNoiseToolStripMenuItem
            // 
            this.removeExcessNoiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateAndFormToolStripMenuItem1,
            this.templateOnlyToolStripMenuItem1,
            this.formOnlyToolStripMenuItem1});
            this.removeExcessNoiseToolStripMenuItem.Name = "removeExcessNoiseToolStripMenuItem";
            this.removeExcessNoiseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removeExcessNoiseToolStripMenuItem.Text = "Remove excess noise";
            this.removeExcessNoiseToolStripMenuItem.Click += new System.EventHandler(this.removeExcessNoiseToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markFormToolStripMenuItem,
            this.markFormAndRetainTemplateToolStripMenuItem});
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.markToolStripMenuItem.Text = "Mark";
            // 
            // markFormToolStripMenuItem
            // 
            this.markFormToolStripMenuItem.Name = "markFormToolStripMenuItem";
            this.markFormToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.markFormToolStripMenuItem.Text = "Mark Form";
            this.markFormToolStripMenuItem.Click += new System.EventHandler(this.markFormToolStripMenuItem_Click);
            // 
            // markFormAndRetainTemplateToolStripMenuItem
            // 
            this.markFormAndRetainTemplateToolStripMenuItem.Name = "markFormAndRetainTemplateToolStripMenuItem";
            this.markFormAndRetainTemplateToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.markFormAndRetainTemplateToolStripMenuItem.Text = "Mark Form and retain template";
            this.markFormAndRetainTemplateToolStripMenuItem.Click += new System.EventHandler(this.markFormAndRetainTemplateToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeImage640x590PixelsToolStripMenuItem,
            this.saveTemplateAsBMPToolStripMenuItem,
            this.saveFormAsBMPToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // resizeImage640x590PixelsToolStripMenuItem
            // 
            this.resizeImage640x590PixelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateAndFormToolStripMenuItem,
            this.templateOnlyToolStripMenuItem,
            this.formOnlyToolStripMenuItem});
            this.resizeImage640x590PixelsToolStripMenuItem.Name = "resizeImage640x590PixelsToolStripMenuItem";
            this.resizeImage640x590PixelsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.resizeImage640x590PixelsToolStripMenuItem.Text = "Resize image (640x594 pixels)";
            this.resizeImage640x590PixelsToolStripMenuItem.Click += new System.EventHandler(this.resizeImage640x590PixelsToolStripMenuItem_Click);
            // 
            // templateAndFormToolStripMenuItem
            // 
            this.templateAndFormToolStripMenuItem.Name = "templateAndFormToolStripMenuItem";
            this.templateAndFormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.templateAndFormToolStripMenuItem.Text = "Template and Form";
            this.templateAndFormToolStripMenuItem.Click += new System.EventHandler(this.templateAndFormToolStripMenuItem_Click);
            // 
            // templateOnlyToolStripMenuItem
            // 
            this.templateOnlyToolStripMenuItem.Name = "templateOnlyToolStripMenuItem";
            this.templateOnlyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.templateOnlyToolStripMenuItem.Text = "Template only";
            this.templateOnlyToolStripMenuItem.Click += new System.EventHandler(this.templateOnlyToolStripMenuItem_Click);
            // 
            // formOnlyToolStripMenuItem
            // 
            this.formOnlyToolStripMenuItem.Name = "formOnlyToolStripMenuItem";
            this.formOnlyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.formOnlyToolStripMenuItem.Text = "Form only";
            this.formOnlyToolStripMenuItem.Click += new System.EventHandler(this.formOnlyToolStripMenuItem_Click);
            // 
            // saveTemplateAsBMPToolStripMenuItem
            // 
            this.saveTemplateAsBMPToolStripMenuItem.Name = "saveTemplateAsBMPToolStripMenuItem";
            this.saveTemplateAsBMPToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveTemplateAsBMPToolStripMenuItem.Text = "Save template as BMP";
            this.saveTemplateAsBMPToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateAsBMPToolStripMenuItem_Click);
            // 
            // saveFormAsBMPToolStripMenuItem
            // 
            this.saveFormAsBMPToolStripMenuItem.Name = "saveFormAsBMPToolStripMenuItem";
            this.saveFormAsBMPToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveFormAsBMPToolStripMenuItem.Text = "Save form as BMP";
            this.saveFormAsBMPToolStripMenuItem.Click += new System.EventHandler(this.saveFormAsBMPToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAndSaveResultToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // openAndSaveResultToolStripMenuItem
            // 
            this.openAndSaveResultToolStripMenuItem.Name = "openAndSaveResultToolStripMenuItem";
            this.openAndSaveResultToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openAndSaveResultToolStripMenuItem.Text = "Open Database";
            this.openAndSaveResultToolStripMenuItem.Click += new System.EventHandler(this.openAndSaveResultToolStripMenuItem_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(14, 648);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(114, 645);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(116, 20);
            this.txtScore.TabIndex = 4;
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(14, 673);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(41, 13);
            this.lblXY.TabIndex = 5;
            this.lblXY.Text = "label1";
            // 
            // lblARGB
            // 
            this.lblARGB.AutoSize = true;
            this.lblARGB.Location = new System.Drawing.Point(14, 698);
            this.lblARGB.Name = "lblARGB";
            this.lblARGB.Size = new System.Drawing.Size(41, 13);
            this.lblARGB.TabIndex = 6;
            this.lblARGB.Text = "label1";
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.Location = new System.Drawing.Point(14, 720);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(41, 13);
            this.lblWH.TabIndex = 7;
            this.lblWH.Text = "label1";
            // 
            // formPb
            // 
            this.formPb.Location = new System.Drawing.Point(689, 38);
            this.formPb.Name = "formPb";
            this.formPb.Size = new System.Drawing.Size(650, 575);
            this.formPb.TabIndex = 1;
            this.formPb.TabStop = false;
            this.formPb.Click += new System.EventHandler(this.formPb_Click);
            this.formPb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formPb_MouseMove);
            // 
            // templatePb
            // 
            this.templatePb.Location = new System.Drawing.Point(12, 38);
            this.templatePb.Name = "templatePb";
            this.templatePb.Size = new System.Drawing.Size(650, 575);
            this.templatePb.TabIndex = 0;
            this.templatePb.TabStop = false;
            this.templatePb.Click += new System.EventHandler(this.templatePb_Click);
            this.templatePb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.templatePb_MouseMove);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(69, 284);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(41, 13);
            this.lblinfo.TabIndex = 8;
            this.lblinfo.Text = "label1";
            // 
            // templateAndFormToolStripMenuItem1
            // 
            this.templateAndFormToolStripMenuItem1.Name = "templateAndFormToolStripMenuItem1";
            this.templateAndFormToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.templateAndFormToolStripMenuItem1.Text = "Template and Form";
            this.templateAndFormToolStripMenuItem1.Click += new System.EventHandler(this.templateAndFormToolStripMenuItem1_Click);
            // 
            // templateOnlyToolStripMenuItem1
            // 
            this.templateOnlyToolStripMenuItem1.Name = "templateOnlyToolStripMenuItem1";
            this.templateOnlyToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.templateOnlyToolStripMenuItem1.Text = "Template only";
            this.templateOnlyToolStripMenuItem1.Click += new System.EventHandler(this.templateOnlyToolStripMenuItem1_Click);
            // 
            // formOnlyToolStripMenuItem1
            // 
            this.formOnlyToolStripMenuItem1.Name = "formOnlyToolStripMenuItem1";
            this.formOnlyToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.formOnlyToolStripMenuItem1.Text = "Form only";
            this.formOnlyToolStripMenuItem1.Click += new System.EventHandler(this.formOnlyToolStripMenuItem1_Click);
            // 
            // frmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblWH);
            this.Controls.Add(this.lblARGB);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.templatePb);
            this.Controls.Add(this.formPb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Marking Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox templatePb;
        private System.Windows.Forms.PictureBox formPb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterIfBlueInkWasUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterIfGreenInkWasUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterIfRedInkWasUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markFormToolStripMenuItem;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.Label lblARGB;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeImage640x590PixelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndSaveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateAsBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFormAsBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markFormAndRetainTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertTemplateOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertFormOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterTemplateOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterFormOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueInkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenInkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redInkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem templateAndFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formOnlyToolStripMenuItem;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.ToolStripMenuItem removeExcessNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateAndFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem templateOnlyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formOnlyToolStripMenuItem1;
    }
}

