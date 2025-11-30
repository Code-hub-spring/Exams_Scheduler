namespace WindowsFormsApp1
{
    partial class MainDashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExamRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvigitatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTheExamRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTheScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvigilatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExamRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExamRoomToolStripMenuItem,
            this.addInvigitatorToolStripMenuItem1,
            this.bookTheExamRoomToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addExamRoomToolStripMenuItem
            // 
            this.addExamRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExamRoomToolStripMenuItem.Name = "addExamRoomToolStripMenuItem";
            this.addExamRoomToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.addExamRoomToolStripMenuItem.Text = "Add Exam Room";
            this.addExamRoomToolStripMenuItem.Click += new System.EventHandler(this.addExamRoomToolStripMenuItem_Click);
            // 
            // addInvigitatorToolStripMenuItem1
            // 
            this.addInvigitatorToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvigitatorToolStripMenuItem1.Name = "addInvigitatorToolStripMenuItem1";
            this.addInvigitatorToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.addInvigitatorToolStripMenuItem1.Text = "Add Invigitator";
            this.addInvigitatorToolStripMenuItem1.Click += new System.EventHandler(this.addInvigitatorToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // bookTheExamRoomToolStripMenuItem
            // 
            this.bookTheExamRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTheExamRoomToolStripMenuItem.Name = "bookTheExamRoomToolStripMenuItem";
            this.bookTheExamRoomToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.bookTheExamRoomToolStripMenuItem.Text = "Exam Room Booking";
            this.bookTheExamRoomToolStripMenuItem.Click += new System.EventHandler(this.bookTheExamRoomToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editScheduleToolStripMenuItem,
            this.cancelTheScheduleToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editScheduleToolStripMenuItem
            // 
            this.editScheduleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editScheduleToolStripMenuItem.Name = "editScheduleToolStripMenuItem";
            this.editScheduleToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.editScheduleToolStripMenuItem.Text = "Edit Schedule";
            this.editScheduleToolStripMenuItem.Click += new System.EventHandler(this.editScheduleToolStripMenuItem_Click);
            // 
            // cancelTheScheduleToolStripMenuItem
            // 
            this.cancelTheScheduleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelTheScheduleToolStripMenuItem.Name = "cancelTheScheduleToolStripMenuItem";
            this.cancelTheScheduleToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.cancelTheScheduleToolStripMenuItem.Text = "Cancel The Schedule";
            this.cancelTheScheduleToolStripMenuItem.Click += new System.EventHandler(this.cancelTheScheduleToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllSchedulesToolStripMenuItem,
            this.viewInvigilatorsToolStripMenuItem,
            this.viewExamRoomsToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewAllSchedulesToolStripMenuItem
            // 
            this.viewAllSchedulesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllSchedulesToolStripMenuItem.Name = "viewAllSchedulesToolStripMenuItem";
            this.viewAllSchedulesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewAllSchedulesToolStripMenuItem.Text = "View All Schedules";
            this.viewAllSchedulesToolStripMenuItem.Click += new System.EventHandler(this.viewAllSchedulesToolStripMenuItem_Click);
            // 
            // viewInvigilatorsToolStripMenuItem
            // 
            this.viewInvigilatorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvigilatorsToolStripMenuItem.Name = "viewInvigilatorsToolStripMenuItem";
            this.viewInvigilatorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewInvigilatorsToolStripMenuItem.Text = "View Invigilators";
            this.viewInvigilatorsToolStripMenuItem.Click += new System.EventHandler(this.viewInvigilatorsToolStripMenuItem_Click);
            // 
            // viewExamRoomsToolStripMenuItem
            // 
            this.viewExamRoomsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewExamRoomsToolStripMenuItem.Name = "viewExamRoomsToolStripMenuItem";
            this.viewExamRoomsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewExamRoomsToolStripMenuItem.Text = "View Exam Rooms";
            this.viewExamRoomsToolStripMenuItem.Click += new System.EventHandler(this.viewExamRoomsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllSchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addExamRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInvigitatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelTheScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvigilatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExamRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTheExamRoomToolStripMenuItem;
    }
}

