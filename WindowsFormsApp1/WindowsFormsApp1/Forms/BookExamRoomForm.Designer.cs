namespace WindowsFormsApp1
{
    partial class BookExamRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomCapacityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InvigilatorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SpecialPermGroupBox = new System.Windows.Forms.GroupBox();
            this.ExtraHoursTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SpecialPermissionCheckBox = new System.Windows.Forms.CheckBox();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalExamHoursLabel = new System.Windows.Forms.Label();
            this.ExamStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExamEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ExamTitleTextBox = new System.Windows.Forms.TextBox();
            this.ExamTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.RetakeRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialRadioButton = new System.Windows.Forms.RadioButton();
            this.FinalRadioButton = new System.Windows.Forms.RadioButton();
            this.MidTermRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialPermGroupBox.SuspendLayout();
            this.ExamTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(236, 135);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(186, 24);
            this.CourseComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select  Exam room";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(236, 203);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(186, 24);
            this.RoomComboBox.TabIndex = 3;
            this.RoomComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Capacity";
            // 
            // RoomCapacityTextBox
            // 
            this.RoomCapacityTextBox.Location = new System.Drawing.Point(619, 205);
            this.RoomCapacityTextBox.Name = "RoomCapacityTextBox";
            this.RoomCapacityTextBox.Size = new System.Drawing.Size(162, 22);
            this.RoomCapacityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Invigilator";
            // 
            // InvigilatorComboBox
            // 
            this.InvigilatorComboBox.FormattingEnabled = true;
            this.InvigilatorComboBox.Location = new System.Drawing.Point(236, 263);
            this.InvigilatorComboBox.Name = "InvigilatorComboBox";
            this.InvigilatorComboBox.Size = new System.Drawing.Size(186, 24);
            this.InvigilatorComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Exam Date";
            // 
            // ExamDateTimePicker
            // 
            this.ExamDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExamDateTimePicker.Location = new System.Drawing.Point(236, 312);
            this.ExamDateTimePicker.Name = "ExamDateTimePicker";
            this.ExamDateTimePicker.Size = new System.Drawing.Size(306, 22);
            this.ExamDateTimePicker.TabIndex = 10;
            // 
            // SpecialPermGroupBox
            // 
            this.SpecialPermGroupBox.Controls.Add(this.ExtraHoursTextBox);
            this.SpecialPermGroupBox.Controls.Add(this.label8);
            this.SpecialPermGroupBox.Controls.Add(this.label7);
            this.SpecialPermGroupBox.Controls.Add(this.StudentNameTextBox);
            this.SpecialPermGroupBox.Location = new System.Drawing.Point(99, 510);
            this.SpecialPermGroupBox.Name = "SpecialPermGroupBox";
            this.SpecialPermGroupBox.Size = new System.Drawing.Size(447, 128);
            this.SpecialPermGroupBox.TabIndex = 11;
            this.SpecialPermGroupBox.TabStop = false;
            this.SpecialPermGroupBox.Text = "Special Permission Details";
            // 
            // ExtraHoursTextBox
            // 
            this.ExtraHoursTextBox.Location = new System.Drawing.Point(178, 70);
            this.ExtraHoursTextBox.Name = "ExtraHoursTextBox";
            this.ExtraHoursTextBox.Size = new System.Drawing.Size(112, 22);
            this.ExtraHoursTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Extra hours Needed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student Name";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(178, 37);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(228, 22);
            this.StudentNameTextBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 12;
            // 
            // SpecialPermissionCheckBox
            // 
            this.SpecialPermissionCheckBox.AutoSize = true;
            this.SpecialPermissionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialPermissionCheckBox.Location = new System.Drawing.Point(98, 468);
            this.SpecialPermissionCheckBox.Name = "SpecialPermissionCheckBox";
            this.SpecialPermissionCheckBox.Size = new System.Drawing.Size(295, 20);
            this.SpecialPermissionCheckBox.TabIndex = 13;
            this.SpecialPermissionCheckBox.Text = "Any Student Need Special Permission ";
            this.SpecialPermissionCheckBox.UseVisualStyleBackColor = true;
          //  this.SpecialPermissionCheckBox.CheckedChanged += new System.EventHandler(this.SpecialPermissionCheckBox_CheckedChanged);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(619, 571);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(223, 25);
            this.ScheduleButton.TabIndex = 14;
            this.ScheduleButton.Text = "Schedule The Exam Room";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Exam Duration:";
            // 
            // TotalExamHoursLabel
            // 
            this.TotalExamHoursLabel.AutoSize = true;
            this.TotalExamHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalExamHoursLabel.Location = new System.Drawing.Point(294, 654);
            this.TotalExamHoursLabel.Name = "TotalExamHoursLabel";
            this.TotalExamHoursLabel.Size = new System.Drawing.Size(50, 16);
            this.TotalExamHoursLabel.TabIndex = 16;
            this.TotalExamHoursLabel.Text = "label1";
            // 
            // ExamStartDateTimePicker
            // 
            this.ExamStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExamStartDateTimePicker.Location = new System.Drawing.Point(236, 371);
            this.ExamStartDateTimePicker.Name = "ExamStartDateTimePicker";
            this.ExamStartDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.ExamStartDateTimePicker.TabIndex = 17;
            // 
            // ExamEndDateTimePicker
            // 
            this.ExamEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExamEndDateTimePicker.Location = new System.Drawing.Point(236, 417);
            this.ExamEndDateTimePicker.Name = "ExamEndDateTimePicker";
            this.ExamEndDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.ExamEndDateTimePicker.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(97, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Start Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "End Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(87, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Exam Title";
            // 
            // ExamTitleTextBox
            // 
            this.ExamTitleTextBox.Location = new System.Drawing.Point(236, 16);
            this.ExamTitleTextBox.Name = "ExamTitleTextBox";
            this.ExamTitleTextBox.Size = new System.Drawing.Size(276, 22);
            this.ExamTitleTextBox.TabIndex = 22;
            // 
            // ExamTypeGroupBox
            // 
            this.ExamTypeGroupBox.Controls.Add(this.RetakeRadioButton);
            this.ExamTypeGroupBox.Controls.Add(this.SpecialRadioButton);
            this.ExamTypeGroupBox.Controls.Add(this.FinalRadioButton);
            this.ExamTypeGroupBox.Controls.Add(this.MidTermRadioButton);
            this.ExamTypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamTypeGroupBox.Location = new System.Drawing.Point(90, 58);
            this.ExamTypeGroupBox.Name = "ExamTypeGroupBox";
            this.ExamTypeGroupBox.Size = new System.Drawing.Size(868, 60);
            this.ExamTypeGroupBox.TabIndex = 25;
            this.ExamTypeGroupBox.TabStop = false;
            this.ExamTypeGroupBox.Text = "Exam Type";
            // 
            // RetakeRadioButton
            // 
            this.RetakeRadioButton.AutoSize = true;
            this.RetakeRadioButton.Location = new System.Drawing.Point(467, 21);
            this.RetakeRadioButton.Name = "RetakeRadioButton";
            this.RetakeRadioButton.Size = new System.Drawing.Size(89, 20);
            this.RetakeRadioButton.TabIndex = 1;
            this.RetakeRadioButton.TabStop = true;
            this.RetakeRadioButton.Text = "Re-Take";
            this.RetakeRadioButton.UseVisualStyleBackColor = true;
            this.RetakeRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // SpecialRadioButton
            // 
            this.SpecialRadioButton.AutoSize = true;
            this.SpecialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialRadioButton.Location = new System.Drawing.Point(341, 21);
            this.SpecialRadioButton.Name = "SpecialRadioButton";
            this.SpecialRadioButton.Size = new System.Drawing.Size(81, 20);
            this.SpecialRadioButton.TabIndex = 0;
            this.SpecialRadioButton.TabStop = true;
            this.SpecialRadioButton.Text = "Special";
            this.SpecialRadioButton.UseVisualStyleBackColor = true;
            this.SpecialRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // FinalRadioButton
            // 
            this.FinalRadioButton.AutoSize = true;
            this.FinalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalRadioButton.Location = new System.Drawing.Point(241, 21);
            this.FinalRadioButton.Name = "FinalRadioButton";
            this.FinalRadioButton.Size = new System.Drawing.Size(62, 20);
            this.FinalRadioButton.TabIndex = 0;
            this.FinalRadioButton.TabStop = true;
            this.FinalRadioButton.Text = "Final";
            this.FinalRadioButton.UseVisualStyleBackColor = true;
            this.FinalRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // MidTermRadioButton
            // 
            this.MidTermRadioButton.AutoSize = true;
            this.MidTermRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidTermRadioButton.Location = new System.Drawing.Point(107, 21);
            this.MidTermRadioButton.Name = "MidTermRadioButton";
            this.MidTermRadioButton.Size = new System.Drawing.Size(93, 20);
            this.MidTermRadioButton.TabIndex = 0;
            this.MidTermRadioButton.TabStop = true;
            this.MidTermRadioButton.Text = "Mid Term";
            this.MidTermRadioButton.UseVisualStyleBackColor = true;
            this.MidTermRadioButton.CheckedChanged += new System.EventHandler(this.MidTermRadioButton_CheckedChanged);
            // 
            // BookExamRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 698);
            this.Controls.Add(this.ExamTypeGroupBox);
            this.Controls.Add(this.ExamTitleTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExamEndDateTimePicker);
            this.Controls.Add(this.ExamStartDateTimePicker);
            this.Controls.Add(this.TotalExamHoursLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.SpecialPermissionCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpecialPermGroupBox);
            this.Controls.Add(this.ExamDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InvigilatorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomCapacityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookExamRoomForm";
            this.Text = "BookExamRoomForm";
            this.Load += new System.EventHandler(this.BookExamRoomForm_Load);
            this.SpecialPermGroupBox.ResumeLayout(false);
            this.SpecialPermGroupBox.PerformLayout();
            this.ExamTypeGroupBox.ResumeLayout(false);
            this.ExamTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomCapacityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox InvigilatorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ExamDateTimePicker;
        private System.Windows.Forms.GroupBox SpecialPermGroupBox;
        private System.Windows.Forms.TextBox ExtraHoursTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox SpecialPermissionCheckBox;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalExamHoursLabel;
        private System.Windows.Forms.DateTimePicker ExamStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker ExamEndDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ExamTitleTextBox;
        private System.Windows.Forms.GroupBox ExamTypeGroupBox;
        private System.Windows.Forms.RadioButton MidTermRadioButton;
        private System.Windows.Forms.RadioButton SpecialRadioButton;
        private System.Windows.Forms.RadioButton FinalRadioButton;
        private System.Windows.Forms.RadioButton RetakeRadioButton;
    }
}