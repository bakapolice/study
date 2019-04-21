namespace Study
{
    partial class Study
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
            this.tabControlStudy = new System.Windows.Forms.TabControl();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataGrid_Students = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_objectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabPageTeacher = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGrid_Teachers = new System.Windows.Forms.DataGridView();
            this.teacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_objectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPageObject = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGrid_Objects = new System.Windows.Forms.DataGridView();
            this.object_objectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_teacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_curseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDeleteObject = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPageCurse = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGrid_Curses = new System.Windows.Forms.DataGridView();
            this.curseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curse_studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curse_objectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curseTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curseMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAddCurse = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonDeleteCurse = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabPageSearchName = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGrid_StudentsCurse = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchStudentCurse = new System.Windows.Forms.Button();
            this.txtbxStudentName = new System.Windows.Forms.TextBox();
            this.tabPageSearchCurses = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGrid_ThemeCurse = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxCurseTheme = new System.Windows.Forms.TextBox();
            this.buttonSearchTheme = new System.Windows.Forms.Button();
            this.tabControlStudy.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Students)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageTeacher.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Teachers)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageObject.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Objects)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageCurse.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Curses)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageSearchName.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StudentsCurse)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPageSearchCurses.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThemeCurse)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudy
            // 
            this.tabControlStudy.Controls.Add(this.tabPageStudent);
            this.tabControlStudy.Controls.Add(this.tabPageTeacher);
            this.tabControlStudy.Controls.Add(this.tabPageObject);
            this.tabControlStudy.Controls.Add(this.tabPageCurse);
            this.tabControlStudy.Controls.Add(this.tabPageSearchName);
            this.tabControlStudy.Controls.Add(this.tabPageSearchCurses);
            this.tabControlStudy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStudy.Location = new System.Drawing.Point(0, 0);
            this.tabControlStudy.Name = "tabControlStudy";
            this.tabControlStudy.SelectedIndex = 0;
            this.tabControlStudy.Size = new System.Drawing.Size(745, 450);
            this.tabControlStudy.TabIndex = 0;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.panel12);
            this.tabPageStudent.Controls.Add(this.panel1);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(737, 424);
            this.tabPageStudent.TabIndex = 0;
            this.tabPageStudent.Text = "Студент";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dataGrid_Students);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(603, 418);
            this.panel12.TabIndex = 2;
            // 
            // dataGrid_Students
            // 
            this.dataGrid_Students.AllowUserToAddRows = false;
            this.dataGrid_Students.AllowUserToDeleteRows = false;
            this.dataGrid_Students.AllowUserToOrderColumns = true;
            this.dataGrid_Students.AllowUserToResizeColumns = false;
            this.dataGrid_Students.AllowUserToResizeRows = false;
            this.dataGrid_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.student_objectID,
            this.studentName,
            this.studentGroup,
            this.studentPhone});
            this.dataGrid_Students.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Students.MultiSelect = false;
            this.dataGrid_Students.Name = "dataGrid_Students";
            this.dataGrid_Students.RowHeadersVisible = false;
            this.dataGrid_Students.Size = new System.Drawing.Size(603, 418);
            this.dataGrid_Students.TabIndex = 0;
            this.dataGrid_Students.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Students_CellEndEdit);
            // 
            // studentID
            // 
            this.studentID.HeaderText = "ID Студента";
            this.studentID.Name = "studentID";
            // 
            // student_objectID
            // 
            this.student_objectID.HeaderText = "ID Предмета";
            this.student_objectID.Name = "student_objectID";
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Имя";
            this.studentName.Name = "studentName";
            // 
            // studentGroup
            // 
            this.studentGroup.HeaderText = "Группа";
            this.studentGroup.Name = "studentGroup";
            // 
            // studentPhone
            // 
            this.studentPhone.HeaderText = "Номер телефона";
            this.studentPhone.Name = "studentPhone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.buttonAddStudent);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonDeleteStudent);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(606, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 418);
            this.panel1.TabIndex = 1;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddStudent.Location = new System.Drawing.Point(-2, 0);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(134, 51);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Tag = "Student";
            this.buttonAddStudent.Text = "Добавить строку";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Study_Load);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteStudent.FlatAppearance.BorderSize = 0;
            this.buttonDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(0, 62);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(134, 51);
            this.buttonDeleteStudent.TabIndex = 1;
            this.buttonDeleteStudent.Tag = "Student";
            this.buttonDeleteStudent.Text = "Удалить выбранную строку";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(-2, 119);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 51);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // tabPageTeacher
            // 
            this.tabPageTeacher.Controls.Add(this.panel11);
            this.tabPageTeacher.Controls.Add(this.panel2);
            this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeacher.Name = "tabPageTeacher";
            this.tabPageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeacher.Size = new System.Drawing.Size(737, 424);
            this.tabPageTeacher.TabIndex = 1;
            this.tabPageTeacher.Text = "Перподаватель";
            this.tabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dataGrid_Teachers);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(603, 418);
            this.panel11.TabIndex = 3;
            // 
            // dataGrid_Teachers
            // 
            this.dataGrid_Teachers.AllowUserToAddRows = false;
            this.dataGrid_Teachers.AllowUserToDeleteRows = false;
            this.dataGrid_Teachers.AllowUserToOrderColumns = true;
            this.dataGrid_Teachers.AllowUserToResizeColumns = false;
            this.dataGrid_Teachers.AllowUserToResizeRows = false;
            this.dataGrid_Teachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherID,
            this.teacher_objectID,
            this.teacherName,
            this.teacherPhone});
            this.dataGrid_Teachers.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Teachers.MultiSelect = false;
            this.dataGrid_Teachers.Name = "dataGrid_Teachers";
            this.dataGrid_Teachers.RowHeadersVisible = false;
            this.dataGrid_Teachers.Size = new System.Drawing.Size(603, 418);
            this.dataGrid_Teachers.TabIndex = 0;
            // 
            // teacherID
            // 
            this.teacherID.HeaderText = "ID Перодавателя";
            this.teacherID.Name = "teacherID";
            // 
            // teacher_objectID
            // 
            this.teacher_objectID.HeaderText = "ID Предмета";
            this.teacher_objectID.Name = "teacher_objectID";
            // 
            // teacherName
            // 
            this.teacherName.HeaderText = "Имя";
            this.teacherName.Name = "teacherName";
            // 
            // teacherPhone
            // 
            this.teacherPhone.HeaderText = "Телефон";
            this.teacherPhone.Name = "teacherPhone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.buttonAddTeacher);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.buttonDeleteTeacher);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(606, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 418);
            this.panel2.TabIndex = 2;
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTeacher.FlatAppearance.BorderSize = 0;
            this.buttonAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddTeacher.Location = new System.Drawing.Point(-2, 0);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(134, 51);
            this.buttonAddTeacher.TabIndex = 3;
            this.buttonAddTeacher.Tag = "Teacher";
            this.buttonAddTeacher.Text = "Добавить строку";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 51);
            this.button4.TabIndex = 2;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Study_Load);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(0, 62);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(134, 51);
            this.buttonDeleteTeacher.TabIndex = 1;
            this.buttonDeleteTeacher.Tag = "Teacher";
            this.buttonDeleteTeacher.Text = "Удалить выбранную строку";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(-2, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 51);
            this.button6.TabIndex = 0;
            this.button6.Text = "Сохранить изменения";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPageObject
            // 
            this.tabPageObject.Controls.Add(this.panel10);
            this.tabPageObject.Controls.Add(this.panel3);
            this.tabPageObject.Location = new System.Drawing.Point(4, 22);
            this.tabPageObject.Name = "tabPageObject";
            this.tabPageObject.Size = new System.Drawing.Size(737, 424);
            this.tabPageObject.TabIndex = 2;
            this.tabPageObject.Text = "Предмет";
            this.tabPageObject.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dataGrid_Objects);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(609, 424);
            this.panel10.TabIndex = 3;
            // 
            // dataGrid_Objects
            // 
            this.dataGrid_Objects.AllowUserToAddRows = false;
            this.dataGrid_Objects.AllowUserToDeleteRows = false;
            this.dataGrid_Objects.AllowUserToOrderColumns = true;
            this.dataGrid_Objects.AllowUserToResizeColumns = false;
            this.dataGrid_Objects.AllowUserToResizeRows = false;
            this.dataGrid_Objects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Objects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Objects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.object_objectID,
            this.object_teacherID,
            this.object_curseID,
            this.curseName});
            this.dataGrid_Objects.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Objects.MultiSelect = false;
            this.dataGrid_Objects.Name = "dataGrid_Objects";
            this.dataGrid_Objects.RowHeadersVisible = false;
            this.dataGrid_Objects.Size = new System.Drawing.Size(609, 424);
            this.dataGrid_Objects.TabIndex = 0;
            // 
            // object_objectID
            // 
            this.object_objectID.HeaderText = "ID Предмета";
            this.object_objectID.Name = "object_objectID";
            // 
            // object_teacherID
            // 
            this.object_teacherID.HeaderText = "ID Преподавателя";
            this.object_teacherID.Name = "object_teacherID";
            // 
            // object_curseID
            // 
            this.object_curseID.HeaderText = "ID Курсовой";
            this.object_curseID.Name = "object_curseID";
            // 
            // curseName
            // 
            this.curseName.HeaderText = "Название";
            this.curseName.Name = "curseName";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.buttonAddObject);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.buttonDeleteObject);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(609, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 424);
            this.panel3.TabIndex = 2;
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddObject.FlatAppearance.BorderSize = 0;
            this.buttonAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddObject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddObject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddObject.Location = new System.Drawing.Point(-2, 0);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(134, 51);
            this.buttonAddObject.TabIndex = 3;
            this.buttonAddObject.Tag = "Object";
            this.buttonAddObject.Text = "Добавить строку";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(0, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 51);
            this.button8.TabIndex = 2;
            this.button8.Text = "Обновить таблицу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Study_Load);
            // 
            // buttonDeleteObject
            // 
            this.buttonDeleteObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteObject.FlatAppearance.BorderSize = 0;
            this.buttonDeleteObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteObject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteObject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteObject.Location = new System.Drawing.Point(0, 62);
            this.buttonDeleteObject.Name = "buttonDeleteObject";
            this.buttonDeleteObject.Size = new System.Drawing.Size(134, 51);
            this.buttonDeleteObject.TabIndex = 1;
            this.buttonDeleteObject.Tag = "Object";
            this.buttonDeleteObject.Text = "Удалить выбранную строку";
            this.buttonDeleteObject.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(-2, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 51);
            this.button10.TabIndex = 0;
            this.button10.Text = "Сохранить изменения";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tabPageCurse
            // 
            this.tabPageCurse.Controls.Add(this.panel9);
            this.tabPageCurse.Controls.Add(this.panel4);
            this.tabPageCurse.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurse.Name = "tabPageCurse";
            this.tabPageCurse.Size = new System.Drawing.Size(737, 424);
            this.tabPageCurse.TabIndex = 3;
            this.tabPageCurse.Text = "Курсовая";
            this.tabPageCurse.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGrid_Curses);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(609, 424);
            this.panel9.TabIndex = 3;
            // 
            // dataGrid_Curses
            // 
            this.dataGrid_Curses.AllowUserToAddRows = false;
            this.dataGrid_Curses.AllowUserToDeleteRows = false;
            this.dataGrid_Curses.AllowUserToResizeColumns = false;
            this.dataGrid_Curses.AllowUserToResizeRows = false;
            this.dataGrid_Curses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Curses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Curses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Curses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curseID,
            this.curse_studentID,
            this.curse_objectID,
            this.curseTask,
            this.curseMark});
            this.dataGrid_Curses.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Curses.MultiSelect = false;
            this.dataGrid_Curses.Name = "dataGrid_Curses";
            this.dataGrid_Curses.RowHeadersVisible = false;
            this.dataGrid_Curses.Size = new System.Drawing.Size(609, 424);
            this.dataGrid_Curses.TabIndex = 0;
            // 
            // curseID
            // 
            this.curseID.HeaderText = "ID Курсовой";
            this.curseID.Name = "curseID";
            // 
            // curse_studentID
            // 
            this.curse_studentID.HeaderText = "ID Студента";
            this.curse_studentID.Name = "curse_studentID";
            // 
            // curse_objectID
            // 
            this.curse_objectID.HeaderText = "ID Предмета";
            this.curse_objectID.Name = "curse_objectID";
            // 
            // curseTask
            // 
            this.curseTask.HeaderText = "Задание";
            this.curseTask.Name = "curseTask";
            // 
            // curseMark
            // 
            this.curseMark.HeaderText = "Оценка";
            this.curseMark.Name = "curseMark";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.buttonAddCurse);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.buttonDeleteCurse);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(609, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 424);
            this.panel4.TabIndex = 2;
            // 
            // buttonAddCurse
            // 
            this.buttonAddCurse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCurse.FlatAppearance.BorderSize = 0;
            this.buttonAddCurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCurse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCurse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddCurse.Location = new System.Drawing.Point(-2, 0);
            this.buttonAddCurse.Name = "buttonAddCurse";
            this.buttonAddCurse.Size = new System.Drawing.Size(134, 51);
            this.buttonAddCurse.TabIndex = 3;
            this.buttonAddCurse.Tag = "Curse";
            this.buttonAddCurse.Text = "Добавить строку";
            this.buttonAddCurse.UseVisualStyleBackColor = true;
            this.buttonAddCurse.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(0, 176);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(128, 51);
            this.button13.TabIndex = 2;
            this.button13.Text = "Обновить таблицу";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Study_Load);
            // 
            // buttonDeleteCurse
            // 
            this.buttonDeleteCurse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCurse.FlatAppearance.BorderSize = 0;
            this.buttonDeleteCurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCurse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCurse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteCurse.Location = new System.Drawing.Point(0, 62);
            this.buttonDeleteCurse.Name = "buttonDeleteCurse";
            this.buttonDeleteCurse.Size = new System.Drawing.Size(134, 51);
            this.buttonDeleteCurse.TabIndex = 1;
            this.buttonDeleteCurse.Tag = "Curse";
            this.buttonDeleteCurse.Text = "Удалить выбранную строку";
            this.buttonDeleteCurse.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(-2, 119);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(128, 51);
            this.button15.TabIndex = 0;
            this.button15.Text = "Сохранить изменения";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // tabPageSearchName
            // 
            this.tabPageSearchName.Controls.Add(this.panel7);
            this.tabPageSearchName.Controls.Add(this.panel5);
            this.tabPageSearchName.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearchName.Name = "tabPageSearchName";
            this.tabPageSearchName.Size = new System.Drawing.Size(737, 424);
            this.tabPageSearchName.TabIndex = 4;
            this.tabPageSearchName.Text = "Поиск по имени студента";
            this.tabPageSearchName.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGrid_StudentsCurse);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(540, 424);
            this.panel7.TabIndex = 4;
            // 
            // dataGrid_StudentsCurse
            // 
            this.dataGrid_StudentsCurse.AllowUserToAddRows = false;
            this.dataGrid_StudentsCurse.AllowUserToDeleteRows = false;
            this.dataGrid_StudentsCurse.AllowUserToOrderColumns = true;
            this.dataGrid_StudentsCurse.AllowUserToResizeColumns = false;
            this.dataGrid_StudentsCurse.AllowUserToResizeRows = false;
            this.dataGrid_StudentsCurse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_StudentsCurse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_StudentsCurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_StudentsCurse.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_StudentsCurse.MultiSelect = false;
            this.dataGrid_StudentsCurse.Name = "dataGrid_StudentsCurse";
            this.dataGrid_StudentsCurse.Size = new System.Drawing.Size(540, 424);
            this.dataGrid_StudentsCurse.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.buttonSearchStudentCurse);
            this.panel5.Controls.Add(this.txtbxStudentName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(540, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 424);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя студента";
            // 
            // buttonSearchStudentCurse
            // 
            this.buttonSearchStudentCurse.FlatAppearance.BorderSize = 0;
            this.buttonSearchStudentCurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchStudentCurse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchStudentCurse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchStudentCurse.Location = new System.Drawing.Point(0, 46);
            this.buttonSearchStudentCurse.Name = "buttonSearchStudentCurse";
            this.buttonSearchStudentCurse.Size = new System.Drawing.Size(197, 51);
            this.buttonSearchStudentCurse.TabIndex = 0;
            this.buttonSearchStudentCurse.Text = "Найти";
            this.buttonSearchStudentCurse.UseVisualStyleBackColor = true;
            this.buttonSearchStudentCurse.Click += new System.EventHandler(this.buttonSearchStudentCurse_Click);
            // 
            // txtbxStudentName
            // 
            this.txtbxStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxStudentName.Location = new System.Drawing.Point(3, 20);
            this.txtbxStudentName.Name = "txtbxStudentName";
            this.txtbxStudentName.Size = new System.Drawing.Size(190, 20);
            this.txtbxStudentName.TabIndex = 3;
            // 
            // tabPageSearchCurses
            // 
            this.tabPageSearchCurses.Controls.Add(this.panel8);
            this.tabPageSearchCurses.Controls.Add(this.panel6);
            this.tabPageSearchCurses.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearchCurses.Name = "tabPageSearchCurses";
            this.tabPageSearchCurses.Size = new System.Drawing.Size(737, 424);
            this.tabPageSearchCurses.TabIndex = 5;
            this.tabPageSearchCurses.Text = "Поиск по теме курсовой";
            this.tabPageSearchCurses.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGrid_ThemeCurse);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(540, 424);
            this.panel8.TabIndex = 6;
            // 
            // dataGrid_ThemeCurse
            // 
            this.dataGrid_ThemeCurse.AllowUserToAddRows = false;
            this.dataGrid_ThemeCurse.AllowUserToDeleteRows = false;
            this.dataGrid_ThemeCurse.AllowUserToOrderColumns = true;
            this.dataGrid_ThemeCurse.AllowUserToResizeColumns = false;
            this.dataGrid_ThemeCurse.AllowUserToResizeRows = false;
            this.dataGrid_ThemeCurse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_ThemeCurse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_ThemeCurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ThemeCurse.Location = new System.Drawing.Point(-4, 0);
            this.dataGrid_ThemeCurse.MultiSelect = false;
            this.dataGrid_ThemeCurse.Name = "dataGrid_ThemeCurse";
            this.dataGrid_ThemeCurse.Size = new System.Drawing.Size(544, 424);
            this.dataGrid_ThemeCurse.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtbxCurseTheme);
            this.panel6.Controls.Add(this.buttonSearchTheme);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(540, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 424);
            this.panel6.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тема курсовой";
            // 
            // txtbxCurseTheme
            // 
            this.txtbxCurseTheme.Location = new System.Drawing.Point(4, 25);
            this.txtbxCurseTheme.Name = "txtbxCurseTheme";
            this.txtbxCurseTheme.Size = new System.Drawing.Size(190, 20);
            this.txtbxCurseTheme.TabIndex = 3;
            // 
            // buttonSearchTheme
            // 
            this.buttonSearchTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchTheme.FlatAppearance.BorderSize = 0;
            this.buttonSearchTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchTheme.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchTheme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchTheme.Location = new System.Drawing.Point(3, 51);
            this.buttonSearchTheme.Name = "buttonSearchTheme";
            this.buttonSearchTheme.Size = new System.Drawing.Size(197, 51);
            this.buttonSearchTheme.TabIndex = 0;
            this.buttonSearchTheme.Text = "Найти";
            this.buttonSearchTheme.UseVisualStyleBackColor = true;
            this.buttonSearchTheme.Click += new System.EventHandler(this.buttonSearchTheme_Click);
            // 
            // Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.tabControlStudy);
            this.MinimumSize = new System.Drawing.Size(761, 489);
            this.Name = "Study";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study";
            this.Load += new System.EventHandler(this.Study_Load);
            this.tabControlStudy.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Students)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageTeacher.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Teachers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPageObject.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Objects)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPageCurse.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Curses)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPageSearchName.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StudentsCurse)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageSearchCurses.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ThemeCurse)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudy;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_Students;
        private System.Windows.Forms.TabPage tabPageObject;
        private System.Windows.Forms.DataGridView dataGrid_Objects;
        private System.Windows.Forms.TabPage tabPageCurse;
        private System.Windows.Forms.DataGridView dataGrid_Curses;
        private System.Windows.Forms.TabPage tabPageSearchName;
        private System.Windows.Forms.TabPage tabPageSearchCurses;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_objectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_objectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_teacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_curseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn curseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn curseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn curse_studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn curse_objectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn curseTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn curseMark;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.TabPage tabPageTeacher;
        private System.Windows.Forms.DataGridView dataGrid_Teachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_objectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherPhone;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonDeleteObject;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddCurse;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonDeleteCurse;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtbxStudentName;
        private System.Windows.Forms.Button buttonSearchStudentCurse;
        private System.Windows.Forms.DataGridView dataGrid_StudentsCurse;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtbxCurseTheme;
        private System.Windows.Forms.Button buttonSearchTheme;
        private System.Windows.Forms.DataGridView dataGrid_ThemeCurse;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}