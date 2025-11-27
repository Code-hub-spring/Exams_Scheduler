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
            ((System.ComponentModel.ISupportInitialize)(this.viewExamRoomdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewExamRoomdataGridView
            // 
            this.viewExamRoomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewExamRoomdataGridView.Location = new System.Drawing.Point(28, 12);
            this.viewExamRoomdataGridView.Name = "viewExamRoomdataGridView";
            this.viewExamRoomdataGridView.RowHeadersWidth = 51;
            this.viewExamRoomdataGridView.RowTemplate.Height = 24;
            this.viewExamRoomdataGridView.Size = new System.Drawing.Size(732, 412);
            this.viewExamRoomdataGridView.TabIndex = 0;
            this.viewExamRoomdataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewExamRoomdataGridView_CellEndEdit);
            // 
            // ViewExamRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewExamRoomdataGridView);
            this.Name = "ViewExamRoomForm";
            this.Text = "ViewExamRoomForm";
            this.Load += new System.EventHandler(this.ViewExamRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewExamRoomdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewExamRoomdataGridView;
    }
}