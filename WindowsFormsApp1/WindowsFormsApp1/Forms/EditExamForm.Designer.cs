   namespace WindowsFormsApp1.Forms
    {
        partial class EditExamForm
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer Generated Code

            private void InitializeComponent()
            {
            this.lblSelectExam = new System.Windows.Forms.Label();
            this.ExamListComboBox = new System.Windows.Forms.ComboBox();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.grpInvigilator = new System.Windows.Forms.GroupBox();
            this.InvigilatorComboBox = new System.Windows.Forms.ComboBox();
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.EndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTimedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamDateTime = new System.Windows.Forms.DateTimePicker();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.grpSpecial = new System.Windows.Forms.GroupBox();
            this.ExtraHoursTextBox = new System.Windows.Forms.TextBox();
            this.lblExtraHours = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.labelDurationText = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RetakeRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialRadioButton = new System.Windows.Forms.RadioButton();
            this.FinalRadioButton = new System.Windows.Forms.RadioButton();
            this.MidTermRadioButton = new System.Windows.Forms.RadioButton();
            this.grpRoom.SuspendLayout();
            this.grpInvigilator.SuspendLayout();
            this.grpDateTime.SuspendLayout();
            this.grpSpecial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectExam
            // 
            this.lblSelectExam.AutoSize = true;
            this.lblSelectExam.Location = new System.Drawing.Point(40, 25);
            this.lblSelectExam.Name = "lblSelectExam";
            this.lblSelectExam.Size = new System.Drawing.Size(85, 16);
            this.lblSelectExam.TabIndex = 0;
            this.lblSelectExam.Text = "Select Exam:";
            // 
            // ExamListComboBox
            // 
            this.ExamListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExamListComboBox.Location = new System.Drawing.Point(160, 22);
            this.ExamListComboBox.Name = "ExamListComboBox";
            this.ExamListComboBox.Size = new System.Drawing.Size(250, 24);
            this.ExamListComboBox.TabIndex = 1;
            this.ExamListComboBox.SelectedIndexChanged += new System.EventHandler(this.cmbExamList_SelectedIndexChanged);
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.txtCapacity);
            this.grpRoom.Controls.Add(this.lblCapacity);
            this.grpRoom.Controls.Add(this.RoomComboBox);
            this.grpRoom.Controls.Add(this.lblRoom);
            this.grpRoom.Location = new System.Drawing.Point(33, 150);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(447, 99);
            this.grpRoom.TabIndex = 3;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Room Information";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(110, 65);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(120, 22);
            this.txtCapacity.TabIndex = 3;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(20, 68);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 16);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "Capacity:";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomComboBox.Location = new System.Drawing.Point(110, 30);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(200, 24);
            this.RoomComboBox.TabIndex = 1;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(20, 33);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(47, 16);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room:";
            // 
            // grpInvigilator
            // 
            this.grpInvigilator.Controls.Add(this.InvigilatorComboBox);
            this.grpInvigilator.Location = new System.Drawing.Point(30, 255);
            this.grpInvigilator.Name = "grpInvigilator";
            this.grpInvigilator.Size = new System.Drawing.Size(450, 70);
            this.grpInvigilator.TabIndex = 4;
            this.grpInvigilator.TabStop = false;
            this.grpInvigilator.Text = "Invigilator";
            // 
            // InvigilatorComboBox
            // 
            this.InvigilatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvigilatorComboBox.Location = new System.Drawing.Point(20, 30);
            this.InvigilatorComboBox.Name = "InvigilatorComboBox";
            this.InvigilatorComboBox.Size = new System.Drawing.Size(400, 24);
            this.InvigilatorComboBox.TabIndex = 0;
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.EndTimeDateTimePicker);
            this.grpDateTime.Controls.Add(this.label2);
            this.grpDateTime.Controls.Add(this.StartTimedateTimePicker);
            this.grpDateTime.Controls.Add(this.label1);
            this.grpDateTime.Controls.Add(this.ExamDateTime);
            this.grpDateTime.Location = new System.Drawing.Point(30, 331);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(647, 120);
            this.grpDateTime.TabIndex = 5;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Exam Date & Time";
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(370, 87);
            this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
            this.EndTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EndTimeDateTimePicker.TabIndex = 4;
            this.EndTimeDateTimePicker.ValueChanged += new System.EventHandler(this.StartTimedateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time";
            // 
            // StartTimedateTimePicker
            // 
            this.StartTimedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimedateTimePicker.Location = new System.Drawing.Point(84, 86);
            this.StartTimedateTimePicker.Name = "StartTimedateTimePicker";
            this.StartTimedateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.StartTimedateTimePicker.TabIndex = 2;
            this.StartTimedateTimePicker.ValueChanged += new System.EventHandler(this.StartTimedateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // ExamDateTime
            // 
            this.ExamDateTime.CustomFormat = "MM/dd/yyyy";
            this.ExamDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExamDateTime.Location = new System.Drawing.Point(20, 30);
            this.ExamDateTime.Name = "ExamDateTime";
            this.ExamDateTime.Size = new System.Drawing.Size(300, 22);
            this.ExamDateTime.TabIndex = 0;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(30, 457);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(152, 20);
            this.chkSpecial.TabIndex = 6;
            this.chkSpecial.Text = "Special Permission?";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // grpSpecial
            // 
            this.grpSpecial.Controls.Add(this.ExtraHoursTextBox);
            this.grpSpecial.Controls.Add(this.lblExtraHours);
            this.grpSpecial.Controls.Add(this.StudentNameTextBox);
            this.grpSpecial.Controls.Add(this.lblStudentName);
            this.grpSpecial.Location = new System.Drawing.Point(30, 501);
            this.grpSpecial.Name = "grpSpecial";
            this.grpSpecial.Size = new System.Drawing.Size(450, 120);
            this.grpSpecial.TabIndex = 7;
            this.grpSpecial.TabStop = false;
            this.grpSpecial.Text = "Special Student Details";
            // 
            // ExtraHoursTextBox
            // 
            this.ExtraHoursTextBox.Location = new System.Drawing.Point(120, 75);
            this.ExtraHoursTextBox.Name = "ExtraHoursTextBox";
            this.ExtraHoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.ExtraHoursTextBox.TabIndex = 3;
            // 
            // lblExtraHours
            // 
            this.lblExtraHours.AutoSize = true;
            this.lblExtraHours.Location = new System.Drawing.Point(20, 78);
            this.lblExtraHours.Name = "lblExtraHours";
            this.lblExtraHours.Size = new System.Drawing.Size(79, 16);
            this.lblExtraHours.TabIndex = 2;
            this.lblExtraHours.Text = "Extra Hours:";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(120, 35);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.StudentNameTextBox.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 38);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(95, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(157, 638);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 16);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "0 Hours";
            // 
            // labelDurationText
            // 
            this.labelDurationText.AutoSize = true;
            this.labelDurationText.Location = new System.Drawing.Point(31, 638);
            this.labelDurationText.Name = "labelDurationText";
            this.labelDurationText.Size = new System.Drawing.Size(94, 16);
            this.labelDurationText.TabIndex = 8;
            this.labelDurationText.Text = "Total Duration:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(30, 680);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(110, 30);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update Exam";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(183, 680);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 30);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Close";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course Name";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(150, 120);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(244, 24);
            this.CourseComboBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RetakeRadioButton);
            this.groupBox1.Controls.Add(this.SpecialRadioButton);
            this.groupBox1.Controls.Add(this.FinalRadioButton);
            this.groupBox1.Controls.Add(this.MidTermRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(34, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Type";
            // 
            // RetakeRadioButton
            // 
            this.RetakeRadioButton.AutoSize = true;
            this.RetakeRadioButton.Location = new System.Drawing.Point(420, 20);
            this.RetakeRadioButton.Name = "RetakeRadioButton";
            this.RetakeRadioButton.Size = new System.Drawing.Size(82, 20);
            this.RetakeRadioButton.TabIndex = 0;
            this.RetakeRadioButton.TabStop = true;
            this.RetakeRadioButton.Text = "Re-Take";
            this.RetakeRadioButton.UseVisualStyleBackColor = true;
            this.RetakeRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // SpecialRadioButton
            // 
            this.SpecialRadioButton.AutoSize = true;
            this.SpecialRadioButton.Location = new System.Drawing.Point(277, 20);
            this.SpecialRadioButton.Name = "SpecialRadioButton";
            this.SpecialRadioButton.Size = new System.Drawing.Size(74, 20);
            this.SpecialRadioButton.TabIndex = 0;
            this.SpecialRadioButton.TabStop = true;
            this.SpecialRadioButton.Text = "Special";
            this.SpecialRadioButton.UseVisualStyleBackColor = true;
            this.SpecialRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // FinalRadioButton
            // 
            this.FinalRadioButton.AutoSize = true;
            this.FinalRadioButton.Location = new System.Drawing.Point(149, 21);
            this.FinalRadioButton.Name = "FinalRadioButton";
            this.FinalRadioButton.Size = new System.Drawing.Size(57, 20);
            this.FinalRadioButton.TabIndex = 0;
            this.FinalRadioButton.TabStop = true;
            this.FinalRadioButton.Text = "Final";
            this.FinalRadioButton.UseVisualStyleBackColor = true;
            this.FinalRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // MidTermRadioButton
            // 
            this.MidTermRadioButton.AutoSize = true;
            this.MidTermRadioButton.Location = new System.Drawing.Point(13, 20);
            this.MidTermRadioButton.Name = "MidTermRadioButton";
            this.MidTermRadioButton.Size = new System.Drawing.Size(85, 20);
            this.MidTermRadioButton.TabIndex = 0;
            this.MidTermRadioButton.TabStop = true;
            this.MidTermRadioButton.Text = "Mid Term";
            this.MidTermRadioButton.UseVisualStyleBackColor = true;
            this.MidTermRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // EditExamForm
            // 
            this.ClientSize = new System.Drawing.Size(729, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.labelDurationText);
            this.Controls.Add(this.grpSpecial);
            this.Controls.Add(this.chkSpecial);
            this.Controls.Add(this.grpDateTime);
            this.Controls.Add(this.grpInvigilator);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.ExamListComboBox);
            this.Controls.Add(this.lblSelectExam);
            this.Name = "EditExamForm";
            this.Text = "Edit Exam Schedule";
            this.Load += new System.EventHandler(this.EditExamForm_Load);
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.grpInvigilator.ResumeLayout(false);
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.grpSpecial.ResumeLayout(false);
            this.grpSpecial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label lblSelectExam;
            private System.Windows.Forms.ComboBox ExamListComboBox;
            private System.Windows.Forms.GroupBox grpRoom;
            private System.Windows.Forms.TextBox txtCapacity;
            private System.Windows.Forms.Label lblCapacity;
            private System.Windows.Forms.ComboBox RoomComboBox;
            private System.Windows.Forms.Label lblRoom;
            private System.Windows.Forms.GroupBox grpInvigilator;
            private System.Windows.Forms.ComboBox InvigilatorComboBox;
            private System.Windows.Forms.GroupBox grpDateTime;
            private System.Windows.Forms.DateTimePicker ExamDateTime;
            private System.Windows.Forms.CheckBox chkSpecial;
            private System.Windows.Forms.GroupBox grpSpecial;
            private System.Windows.Forms.TextBox ExtraHoursTextBox;
            private System.Windows.Forms.Label lblExtraHours;
            private System.Windows.Forms.TextBox StudentNameTextBox;
            private System.Windows.Forms.Label lblStudentName;
            private System.Windows.Forms.Label lblDuration;
            private System.Windows.Forms.Label labelDurationText;
            private System.Windows.Forms.Button UpdateButton;
            private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker EndTimeDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartTimedateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RetakeRadioButton;
        private System.Windows.Forms.RadioButton SpecialRadioButton;
        private System.Windows.Forms.RadioButton FinalRadioButton;
        private System.Windows.Forms.RadioButton MidTermRadioButton;
    }
    }

