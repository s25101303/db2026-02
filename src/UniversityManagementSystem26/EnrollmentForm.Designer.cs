namespace UniversityManagementSystem26
{
    partial class EnrollmentForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label course_idLabel;
            System.Windows.Forms.Label sec_idLabel;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label gradeLabel;
            this.universityDataSet = new UniversityManagementSystem26.UniversityDataSet();
            this.takesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.takesTableAdapter = new UniversityManagementSystem26.UniversityDataSetTableAdapters.takesTableAdapter();
            this.tableAdapterManager = new UniversityManagementSystem26.UniversityDataSetTableAdapters.TableAdapterManager();
            this.takesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.course_idTextBox = new System.Windows.Forms.TextBox();
            this.sec_idTextBox = new System.Windows.Forms.TextBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            iDLabel = new System.Windows.Forms.Label();
            course_idLabel = new System.Windows.Forms.Label();
            sec_idLabel = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(22, 41);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // course_idLabel
            // 
            course_idLabel.AutoSize = true;
            course_idLabel.Location = new System.Drawing.Point(22, 73);
            course_idLabel.Name = "course_idLabel";
            course_idLabel.Size = new System.Drawing.Size(77, 20);
            course_idLabel.TabIndex = 3;
            course_idLabel.Text = "course id:";
            // 
            // sec_idLabel
            // 
            sec_idLabel.AutoSize = true;
            sec_idLabel.Location = new System.Drawing.Point(22, 105);
            sec_idLabel.Name = "sec_idLabel";
            sec_idLabel.Size = new System.Drawing.Size(54, 20);
            sec_idLabel.TabIndex = 5;
            sec_idLabel.Text = "sec id:";
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new System.Drawing.Point(22, 137);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(79, 20);
            semesterLabel.TabIndex = 7;
            semesterLabel.Text = "semester:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(22, 169);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(43, 20);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "year:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(22, 201);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(54, 20);
            gradeLabel.TabIndex = 11;
            gradeLabel.Text = "grade:";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // takesBindingSource
            // 
            this.takesBindingSource.DataMember = "takes";
            this.takesBindingSource.DataSource = this.universityDataSet;
            // 
            // takesTableAdapter
            // 
            this.takesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = this.takesTableAdapter;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversityManagementSystem26.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // takesDataGridView
            // 
            this.takesDataGridView.AutoGenerateColumns = false;
            this.takesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.takesDataGridView.DataSource = this.takesBindingSource;
            this.takesDataGridView.Location = new System.Drawing.Point(260, 160);
            this.takesDataGridView.Name = "takesDataGridView";
            this.takesDataGridView.RowHeadersWidth = 62;
            this.takesDataGridView.RowTemplate.Height = 28;
            this.takesDataGridView.Size = new System.Drawing.Size(987, 269);
            this.takesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "course_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sec_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "sec_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "semester";
            this.dataGridViewTextBoxColumn4.HeaderText = "semester";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn5.HeaderText = "year";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "grade";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(107, 38);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // course_idTextBox
            // 
            this.course_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "course_id", true));
            this.course_idTextBox.Location = new System.Drawing.Point(107, 70);
            this.course_idTextBox.Name = "course_idTextBox";
            this.course_idTextBox.Size = new System.Drawing.Size(100, 26);
            this.course_idTextBox.TabIndex = 4;
            // 
            // sec_idTextBox
            // 
            this.sec_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "sec_id", true));
            this.sec_idTextBox.Location = new System.Drawing.Point(107, 102);
            this.sec_idTextBox.Name = "sec_idTextBox";
            this.sec_idTextBox.Size = new System.Drawing.Size(100, 26);
            this.sec_idTextBox.TabIndex = 6;
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "semester", true));
            this.semesterTextBox.Location = new System.Drawing.Point(107, 134);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(100, 26);
            this.semesterTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(107, 166);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearTextBox.TabIndex = 10;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.takesBindingSource, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(107, 198);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 26);
            this.gradeTextBox.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(851, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 45);
            this.button5.TabIndex = 18;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(699, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 45);
            this.button4.TabIndex = 17;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(this.gradeTextBox);
            this.panel1.Controls.Add(gradeLabel);
            this.panel1.Controls.Add(this.yearTextBox);
            this.panel1.Controls.Add(yearLabel);
            this.panel1.Controls.Add(this.semesterTextBox);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(semesterLabel);
            this.panel1.Controls.Add(this.sec_idTextBox);
            this.panel1.Controls.Add(course_idLabel);
            this.panel1.Controls.Add(sec_idLabel);
            this.panel1.Controls.Add(this.course_idTextBox);
            this.panel1.Location = new System.Drawing.Point(14, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 269);
            this.panel1.TabIndex = 19;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1258, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.takesDataGridView);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource takesBindingSource;
        private UniversityDataSetTableAdapters.takesTableAdapter takesTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView takesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox course_idTextBox;
        private System.Windows.Forms.TextBox sec_idTextBox;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}