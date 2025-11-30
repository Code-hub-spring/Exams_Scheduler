namespace WindowsFormsApp1.Forms
{
    partial class ViewExamRoomForm
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
            this.viewExamRoomdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewExamRoomdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewExamRoomdataGridView
            // 
            this.viewExamRoomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewExamRoomdataGridView.Location = new System.Drawing.Point(22, 51);
            this.viewExamRoomdataGridView.Name = "viewExamRoomdataGridView";
            this.viewExamRoomdataGridView.RowHeadersWidth = 51;
            this.viewExamRoomdataGridView.RowTemplate.Height = 24;
            this.viewExamRoomdataGridView.Size = new System.Drawing.Size(685, 451);
            this.viewExamRoomdataGridView.TabIndex = 0;
            this.viewExamRoomdataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewExamRoomdataGridView_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Exam Rooms";
            // 
            // ViewExamRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewExamRoomdataGridView);
            this.Name = "ViewExamRoomForm";
            this.Text = "ViewExamRoomForm";
            this.Load += new System.EventHandler(this.ViewExamRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewExamRoomdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewExamRoomdataGridView;
        private System.Windows.Forms.Label label1;
    }
}