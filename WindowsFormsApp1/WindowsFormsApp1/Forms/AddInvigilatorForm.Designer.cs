namespace WindowsFormsApp1
{
    partial class AddInvigilatorForm
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
            this.InvigilatorTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InvigilatorEmpIdTextBox = new System.Windows.Forms.TextBox();
            this.IsAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invigilator Name";
            // 
            // InvigilatorTextBox
            // 
            this.InvigilatorTextBox.Location = new System.Drawing.Point(197, 45);
            this.InvigilatorTextBox.Name = "InvigilatorTextBox";
            this.InvigilatorTextBox.Size = new System.Drawing.Size(100, 22);
            this.InvigilatorTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(197, 177);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invigilator EmpID";
            // 
            // InvigilatorEmpIdTextBox
            // 
            this.InvigilatorEmpIdTextBox.Location = new System.Drawing.Point(197, 89);
            this.InvigilatorEmpIdTextBox.Name = "InvigilatorEmpIdTextBox";
            this.InvigilatorEmpIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.InvigilatorEmpIdTextBox.TabIndex = 4;
            // 
            // IsAvailableCheckBox
            // 
            this.IsAvailableCheckBox.AutoSize = true;
            this.IsAvailableCheckBox.Location = new System.Drawing.Point(66, 140);
            this.IsAvailableCheckBox.Name = "IsAvailableCheckBox";
            this.IsAvailableCheckBox.Size = new System.Drawing.Size(99, 20);
            this.IsAvailableCheckBox.TabIndex = 6;
            this.IsAvailableCheckBox.Text = "Is Available";
            this.IsAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddInvigilatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsAvailableCheckBox);
            this.Controls.Add(this.InvigilatorEmpIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InvigilatorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddInvigilatorForm";
            this.Text = "AddInvigilatorForm";
            this.Load += new System.EventHandler(this.AddInvigilatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InvigilatorTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InvigilatorEmpIdTextBox;
        private System.Windows.Forms.CheckBox IsAvailableCheckBox;
    }
}