
namespace SqlProject
{
    partial class Studentf
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentInfo_GV = new System.Windows.Forms.DataGridView();
            this.Cousrename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exams = new System.Windows.Forms.ComboBox();
            this.Courses = new System.Windows.Forms.ComboBox();
            this.StartExam_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo_GV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.StudentInfo_GV);
            this.tabPage1.Controls.Add(this.StdName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Courses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Today\'s Date:";
            // 
            // StudentInfo_GV
            // 
            this.StudentInfo_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cousrename,
            this.Exam_ID,
            this.Grade});
            this.StudentInfo_GV.Location = new System.Drawing.Point(181, 7);
            this.StudentInfo_GV.Name = "StudentInfo_GV";
            this.StudentInfo_GV.Size = new System.Drawing.Size(343, 308);
            this.StudentInfo_GV.TabIndex = 2;
            // 
            // Cousrename
            // 
            this.Cousrename.HeaderText = "Course Name";
            this.Cousrename.Name = "Cousrename";
            // 
            // Exam_ID
            // 
            this.Exam_ID.HeaderText = "Exam ID";
            this.Exam_ID.Name = "Exam_ID";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // StdName
            // 
            this.StdName.AutoSize = true;
            this.StdName.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdName.Location = new System.Drawing.Point(64, 7);
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(56, 18);
            this.StdName.TabIndex = 1;
            this.StdName.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Exams);
            this.tabPage2.Controls.Add(this.Courses);
            this.tabPage2.Controls.Add(this.StartExam_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Avilable Exames:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses:";
            // 
            // Exams
            // 
            this.Exams.FormattingEnabled = true;
            this.Exams.Location = new System.Drawing.Point(331, 90);
            this.Exams.Name = "Exams";
            this.Exams.Size = new System.Drawing.Size(143, 21);
            this.Exams.TabIndex = 2;
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(69, 90);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(142, 21);
            this.Courses.TabIndex = 1;
            this.Courses.SelectedIndexChanged += new System.EventHandler(this.Courses_SelectedIndexChanged);
            // 
            // StartExam_btn
            // 
            this.StartExam_btn.Location = new System.Drawing.Point(176, 170);
            this.StartExam_btn.Name = "StartExam_btn";
            this.StartExam_btn.Size = new System.Drawing.Size(179, 23);
            this.StartExam_btn.TabIndex = 0;
            this.StartExam_btn.Text = "Start Exam";
            this.StartExam_btn.UseVisualStyleBackColor = true;
            this.StartExam_btn.Click += new System.EventHandler(this.StartExam_btn_Click);
            // 
            // Studentf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 342);
            this.Controls.Add(this.tabControl1);
            this.Name = "Studentf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Studentf_FormClosing);
            this.Load += new System.EventHandler(this.Studentf_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo_GV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label StdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button StartExam_btn;
        private System.Windows.Forms.ComboBox Exams;
        private System.Windows.Forms.ComboBox Courses;
        private System.Windows.Forms.DataGridView StudentInfo_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cousrename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}