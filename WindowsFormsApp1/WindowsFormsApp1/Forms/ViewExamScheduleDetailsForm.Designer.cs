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
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamScheduleDataGridView
            // 
            this.ExamScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamScheduleDataGridView.Location = new System.Drawing.Point(12, 22);
            this.ExamScheduleDataGridView.Name = "ExamScheduleDataGridView";
            this.ExamScheduleDataGridView.RowHeadersWidth = 51;
            this.ExamScheduleDataGridView.RowTemplate.Height = 24;
            this.ExamScheduleDataGridView.Size = new System.Drawing.Size(776, 416);
            this.ExamScheduleDataGridView.TabIndex = 0;
            // 
            // ViewExamScheduleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExamScheduleDataGridView);
            this.Name = "ViewExamScheduleDetailsForm";
            this.Text = "ViewExamScheduleDetailsForm";
            this.Load += new System.EventHandler(this.ViewExamScheduleDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamScheduleDataGridView;
    }
}