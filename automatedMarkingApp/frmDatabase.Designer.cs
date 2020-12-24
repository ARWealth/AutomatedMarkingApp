namespace automatedMarkingApp
{
    partial class frmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetID = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetID);
            this.groupBox1.Controls.Add(this.lblFeedback);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.lblSID);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblMName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.tbFeedback);
            this.groupBox1.Controls.Add(this.tbScore);
            this.groupBox1.Controls.Add(this.tbSID);
            this.groupBox1.Controls.Add(this.tbLName);
            this.groupBox1.Controls.Add(this.tbMName);
            this.groupBox1.Controls.Add(this.tbFName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // btnGetID
            // 
            this.btnGetID.Location = new System.Drawing.Point(248, 16);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(240, 23);
            this.btnGetID.TabIndex = 15;
            this.btnGetID.Text = "Click to get ID for new student";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(245, 130);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(67, 13);
            this.lblFeedback.TabIndex = 14;
            this.lblFeedback.Text = "Feedback:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(7, 127);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 13);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Score:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(7, 22);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(52, 13);
            this.lblSID.TabIndex = 12;
            this.lblSID.Text = "SID No:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(519, 70);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(71, 13);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(245, 70);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(84, 13);
            this.lblMName.TabIndex = 10;
            this.lblMName.Text = "Middle Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(7, 71);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(71, 13);
            this.lblFName.TabIndex = 9;
            this.lblFName.Text = "First Name:";
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(348, 130);
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(394, 20);
            this.tbFeedback.TabIndex = 6;
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(84, 127);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(116, 20);
            this.tbScore.TabIndex = 5;
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(84, 19);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(116, 20);
            this.tbSID.TabIndex = 1;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(626, 68);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(116, 20);
            this.tbLName.TabIndex = 4;
            // 
            // tbMName
            // 
            this.tbMName.Location = new System.Drawing.Point(348, 67);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(116, 20);
            this.tbMName.TabIndex = 3;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(84, 67);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(116, 20);
            this.tbFName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(332, 190);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(107, 52);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Register new student";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 193);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(10, 190);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(107, 52);
            this.btnLoadTable.TabIndex = 6;
            this.btnLoadTable.Text = "Load Table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(635, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(483, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 52);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 452);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Table";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.Button btnDelete;
    }
}