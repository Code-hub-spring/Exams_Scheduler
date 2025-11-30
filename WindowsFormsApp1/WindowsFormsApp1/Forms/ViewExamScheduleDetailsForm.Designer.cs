namespace WindowsFormsApp1
{
    partial class ViewExamScheduleDetailsForm
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
            this.ExamScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamScheduleDataGridView
            // 
            this.ExamScheduleDataGridView.ColumnHeadersHeight = 29;
            this.ExamScheduleDataGridView.Location = new System.Drawing.Point(12, 54);
            this.ExamScheduleDataGridView.Name = "ExamScheduleDataGridView";
            this.ExamScheduleDataGridView.RowHeadersWidth = 51;
            this.ExamScheduleDataGridView.RowTemplate.Height = 24;
            this.ExamScheduleDataGridView.Size = new System.Drawing.Size(1168, 678);
            this.ExamScheduleDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "View The Exam Schedules";
            // 
            // ViewExamScheduleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExamScheduleDataGridView);
            this.Name = "ViewExamScheduleDetailsForm";
            this.Text = "ViewExamScheduleDetailsForm";
            this.Load += new System.EventHandler(this.ViewExamScheduleDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamScheduleDataGridView;
        private System.Windows.Forms.Label label1;
    }
}