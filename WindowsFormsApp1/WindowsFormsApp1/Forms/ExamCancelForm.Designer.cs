namespace WindowsFormsApp1.Forms
{
    partial class ExamCancelForm
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
            this.ExamIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.ExamDateTextBox = new System.Windows.Forms.TextBox();
            this.InvigilatorNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelExamButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExamDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExamIdComboBox
            // 
            this.ExamIdComboBox.FormattingEnabled = true;
            this.ExamIdComboBox.Location = new System.Drawing.Point(214, 60);
            this.ExamIdComboBox.Name = "ExamIdComboBox";
            this.ExamIdComboBox.Size = new System.Drawing.Size(187, 24);
            this.ExamIdComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Exam";
            // 
            // ExamDetailsGroupBox
            // 
            this.ExamDetailsGroupBox.Controls.Add(this.EndTimeTextBox);
            this.ExamDetailsGroupBox.Controls.Add(this.label7);
            this.ExamDetailsGroupBox.Controls.Add(this.label6);
            this.ExamDetailsGroupBox.Controls.Add(this.label5);
            this.ExamDetailsGroupBox.Controls.Add(this.label4);
            this.ExamDetailsGroupBox.Controls.Add(this.label3);
            this.ExamDetailsGroupBox.Controls.Add(this.label2);
            this.ExamDetailsGroupBox.Controls.Add(this.startTimeTextBox);
            this.ExamDetailsGroupBox.Controls.Add(this.ExamDateTextBox);
            this.ExamDetailsGroupBox.Controls.Add(this.InvigilatorNameTextBox);
            this.ExamDetailsGroupBox.Controls.Add(this.RoomNameTextBox);
            this.ExamDetailsGroupBox.Controls.Add(this.CourseNameTextBox);
            this.ExamDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamDetailsGroupBox.Location = new System.Drawing.Point(62, 106);
            this.ExamDetailsGroupBox.Name = "ExamDetailsGroupBox";
            this.ExamDetailsGroupBox.Size = new System.Drawing.Size(624, 346);
            this.ExamDetailsGroupBox.TabIndex = 2;
            this.ExamDetailsGroupBox.TabStop = false;
            this.ExamDetailsGroupBox.Text = "Scheduled Exam Details: ";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(152, 297);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.ReadOnly = true;
            this.EndTimeTextBox.Size = new System.Drawing.Size(227, 22);
            this.EndTimeTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Start Time ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Exam Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Invigilator Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(152, 244);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.ReadOnly = true;
            this.startTimeTextBox.Size = new System.Drawing.Size(227, 22);
            this.startTimeTextBox.TabIndex = 0;
            // 
            // ExamDateTextBox
            // 
            this.ExamDateTextBox.Location = new System.Drawing.Point(152, 186);
            this.ExamDateTextBox.Name = "ExamDateTextBox";
            this.ExamDateTextBox.ReadOnly = true;
            this.ExamDateTextBox.Size = new System.Drawing.Size(227, 22);
            this.ExamDateTextBox.TabIndex = 0;
            // 
            // InvigilatorNameTextBox
            // 
            this.InvigilatorNameTextBox.Location = new System.Drawing.Point(152, 138);
            this.InvigilatorNameTextBox.Name = "InvigilatorNameTextBox";
            this.InvigilatorNameTextBox.ReadOnly = true;
            this.InvigilatorNameTextBox.Size = new System.Drawing.Size(227, 22);
            this.InvigilatorNameTextBox.TabIndex = 0;
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(152, 84);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.ReadOnly = true;
            this.RoomNameTextBox.Size = new System.Drawing.Size(227, 22);
            this.RoomNameTextBox.TabIndex = 0;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(152, 35);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.ReadOnly = true;
            this.CourseNameTextBox.Size = new System.Drawing.Size(227, 22);
            this.CourseNameTextBox.TabIndex = 0;
            // 
            // CancelExamButton
            // 
            this.CancelExamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelExamButton.Location = new System.Drawing.Point(62, 477);
            this.CancelExamButton.Name = "CancelExamButton";
            this.CancelExamButton.Size = new System.Drawing.Size(151, 33);
            this.CancelExamButton.TabIndex = 3;
            this.CancelExamButton.Text = "Cancel The Exam";
            this.CancelExamButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cancel The Exam Schedule";
            // 
            // ExamCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelExamButton);
            this.Controls.Add(this.ExamDetailsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExamIdComboBox);
            this.Name = "ExamCancelForm";
            this.Text = "ExamCancelForm";
            this.Load += new System.EventHandler(this.ExamCancelForm_Load);
            this.ExamDetailsGroupBox.ResumeLayout(false);
            this.ExamDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExamIdComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ExamDetailsGroupBox;
        private System.Windows.Forms.TextBox CourseNameTextBox;
        private System.Windows.Forms.Button CancelExamButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox ExamDateTextBox;
        private System.Windows.Forms.TextBox InvigilatorNameTextBox;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}