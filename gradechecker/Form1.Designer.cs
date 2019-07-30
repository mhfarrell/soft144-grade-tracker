namespace gradechecker
{
    partial class GradeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumModules = new System.Windows.Forms.Label();
            this.lblOverallMark = new System.Windows.Forms.Label();
            this.lstModule = new System.Windows.Forms.ListBox();
            this.lblListSel = new System.Windows.Forms.Label();
            this.lstAssessment = new System.Windows.Forms.ListBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblModMark = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblModCredit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAssessWeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAssessName = new System.Windows.Forms.Label();
            this.lblAssessMark = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(7, 24);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(173, 29);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(964, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Modules:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(964, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Overall Mark:";
            // 
            // lblNumModules
            // 
            this.lblNumModules.AutoSize = true;
            this.lblNumModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumModules.Location = new System.Drawing.Point(1103, 53);
            this.lblNumModules.Name = "lblNumModules";
            this.lblNumModules.Size = new System.Drawing.Size(16, 18);
            this.lblNumModules.TabIndex = 6;
            this.lblNumModules.Text = "0";
            // 
            // lblOverallMark
            // 
            this.lblOverallMark.AutoSize = true;
            this.lblOverallMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallMark.Location = new System.Drawing.Point(1103, 71);
            this.lblOverallMark.Name = "lblOverallMark";
            this.lblOverallMark.Size = new System.Drawing.Size(16, 18);
            this.lblOverallMark.TabIndex = 7;
            this.lblOverallMark.Text = "0";
            // 
            // lstModule
            // 
            this.lstModule.FormattingEnabled = true;
            this.lstModule.Location = new System.Drawing.Point(12, 132);
            this.lstModule.Name = "lstModule";
            this.lstModule.Size = new System.Drawing.Size(120, 108);
            this.lstModule.TabIndex = 8;
            this.lstModule.SelectedIndexChanged += new System.EventHandler(this.lstModule_SelectedIndexChanged);
            // 
            // lblListSel
            // 
            this.lblListSel.AutoSize = true;
            this.lblListSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblListSel.Location = new System.Drawing.Point(162, 106);
            this.lblListSel.Name = "lblListSel";
            this.lblListSel.Size = new System.Drawing.Size(12, 18);
            this.lblListSel.TabIndex = 9;
            this.lblListSel.Text = " ";
            // 
            // lstAssessment
            // 
            this.lstAssessment.FormattingEnabled = true;
            this.lstAssessment.Location = new System.Drawing.Point(507, 132);
            this.lstAssessment.Name = "lstAssessment";
            this.lstAssessment.Size = new System.Drawing.Size(283, 108);
            this.lstAssessment.TabIndex = 10;
            this.lstAssessment.SelectedIndexChanged += new System.EventHandler(this.lstAssessment_SelectedIndexChanged);
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuName.Location = new System.Drawing.Point(12, 53);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(102, 18);
            this.lblStuName.TabIndex = 11;
            this.lblStuName.Text = "Student Name";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(12, 71);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(76, 18);
            this.lblStuID.TabIndex = 12;
            this.lblStuID.Text = "Student ID";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(12, 89);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(103, 18);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Student D.O.B";
            // 
            // lblModMark
            // 
            this.lblModMark.AutoSize = true;
            this.lblModMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMark.Location = new System.Drawing.Point(240, 155);
            this.lblModMark.Name = "lblModMark";
            this.lblModMark.Size = new System.Drawing.Size(16, 18);
            this.lblModMark.TabIndex = 15;
            this.lblModMark.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Module Mark:";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModName.Location = new System.Drawing.Point(138, 137);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(97, 18);
            this.lblModName.TabIndex = 16;
            this.lblModName.Text = "ModuleName";
            // 
            // lblModCredit
            // 
            this.lblModCredit.AutoSize = true;
            this.lblModCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModCredit.Location = new System.Drawing.Point(240, 173);
            this.lblModCredit.Name = "lblModCredit";
            this.lblModCredit.Size = new System.Drawing.Size(16, 18);
            this.lblModCredit.TabIndex = 18;
            this.lblModCredit.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Credits:";
            // 
            // lblAssessWeight
            // 
            this.lblAssessWeight.AutoSize = true;
            this.lblAssessWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessWeight.Location = new System.Drawing.Point(907, 173);
            this.lblAssessWeight.Name = "lblAssessWeight";
            this.lblAssessWeight.Size = new System.Drawing.Size(16, 18);
            this.lblAssessWeight.TabIndex = 23;
            this.lblAssessWeight.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Weight:";
            // 
            // lblAssessName
            // 
            this.lblAssessName.AutoSize = true;
            this.lblAssessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessName.Location = new System.Drawing.Point(805, 137);
            this.lblAssessName.Name = "lblAssessName";
            this.lblAssessName.Size = new System.Drawing.Size(134, 18);
            this.lblAssessName.TabIndex = 21;
            this.lblAssessName.Text = "Assessment Name";
            // 
            // lblAssessMark
            // 
            this.lblAssessMark.AutoSize = true;
            this.lblAssessMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessMark.Location = new System.Drawing.Point(907, 155);
            this.lblAssessMark.Name = "lblAssessMark";
            this.lblAssessMark.Size = new System.Drawing.Size(16, 18);
            this.lblAssessMark.TabIndex = 20;
            this.lblAssessMark.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mark:";
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 344);
            this.Controls.Add(this.lblAssessWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAssessName);
            this.Controls.Add(this.lblAssessMark);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblModCredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblModMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblStuID);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lstAssessment);
            this.Controls.Add(this.lblListSel);
            this.Controls.Add(this.lstModule);
            this.Controls.Add(this.lblOverallMark);
            this.Controls.Add(this.lblNumModules);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GradeForm";
            this.Text = "Grade Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumModules;
        private System.Windows.Forms.Label lblOverallMark;
        private System.Windows.Forms.ListBox lstModule;
        private System.Windows.Forms.Label lblListSel;
        private System.Windows.Forms.ListBox lstAssessment;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblModMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAssessWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAssessName;
        private System.Windows.Forms.Label lblAssessMark;
        private System.Windows.Forms.Label label9;
    }
}

