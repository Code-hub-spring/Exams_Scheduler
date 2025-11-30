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
            this.label1 = new System.Windows.Forms.Label();
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
            this.viewInvigilatorDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewInvigilatorDataGridView_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Invigilators";
            // 
            // ViewInvigilatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewInvigilatorDataGridView);
            this.Name = "ViewInvigilatorForm";
            this.Text = "ViewInvigilatorForm";
            this.Load += new System.EventHandler(this.ViewInvigilatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewInvigilatorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewInvigilatorDataGridView;
        private System.Windows.Forms.Label label1;
    }
}