namespace WindowsFormsApp1.Forms
{
    partial class ViewInvigilatorForm
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
            this.viewInvigilatorDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewInvigilatorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewInvigilatorDataGridView
            // 
            this.viewInvigilatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInvigilatorDataGridView.Location = new System.Drawing.Point(54, 49);
            this.viewInvigilatorDataGridView.Name = "viewInvigilatorDataGridView";
            this.viewInvigilatorDataGridView.RowHeadersWidth = 51;
            this.viewInvigilatorDataGridView.RowTemplate.Height = 24;
            this.viewInvigilatorDataGridView.Size = new System.Drawing.Size(671, 353);
            this.viewInvigilatorDataGridView.TabIndex = 0;
            // 
            // ViewInvigilatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewInvigilatorDataGridView);
            this.Name = "ViewInvigilatorForm";
            this.Text = "ViewInvigilatorForm";
            this.Load += new System.EventHandler(this.ViewInvigilatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewInvigilatorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewInvigilatorDataGridView;
    }
}