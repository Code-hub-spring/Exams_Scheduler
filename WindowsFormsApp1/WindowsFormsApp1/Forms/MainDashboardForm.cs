using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;


namespace WindowsFormsApp1
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            //display view exam room detils
            ViewExamScheduleDetailsForm viewExamScheduleDetailsForm = ViewExamScheduleDetailsForm.GetViewExamScheduleDetailsFormInstance();
            viewExamScheduleDetailsForm.MdiParent = this;
            viewExamScheduleDetailsForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExamRoomForm addExamRoomForm = new AddExamRoomForm();
            addExamRoomForm.MdiParent = this;
            addExamRoomForm.Show();
        }

        //private void addExamToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    AddExamRoomForm addExamRoomForm = new AddExamRoomForm();
        //}

        private void addInvigitatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOpenedForms();
            AddInvigilatorForm addInvigilator = AddInvigilatorForm.GetAddInvigilatorFormInstance();
            addInvigilator.MdiParent = this;
            addInvigilator.Show();
        }

        private void bookTheExamRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an instantance using static method and
            this.CloseOpenedForms();
            BookExamRoomForm bookExamRoomForm =  BookExamRoomForm.GetInstance();
            bookExamRoomForm.MdiParent = this;
            bookExamRoomForm.Show();


        }

        private void viewAllSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //should call static method to create instance
            ViewExamScheduleDetailsForm viewExamScheduleDetailsForm = ViewExamScheduleDetailsForm.GetViewExamScheduleDetailsFormInstance();
            viewExamScheduleDetailsForm.MdiParent= this;
             viewExamScheduleDetailsForm.Show();
        }

        private void addExamRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // AddExamRoomForm addExamRoom=new AddExamRoomForm();
            this.CloseOpenedForms();
            AddExamRoomForm addExamRoom = AddExamRoomForm.GetAddExamRoomFormInstance();
            addExamRoom.MdiParent= this;
            addExamRoom.Show();
        }

        private void cancelTheScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOpenedForms();
            ExamCancelForm examCancelForm = ExamCancelForm.GetExamCancelFormInstance();
            examCancelForm.MdiParent= this;
            examCancelForm.Show();

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent= this;
            aboutForm.Show();
        }

        private void editScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOpenedForms();
            EditExamForm editExam=EditExamForm.GetEditExamFormInstance();
            editExam.MdiParent= this;
            editExam.Show();
        }

        private void viewInvigilatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOpenedForms();
            ViewInvigilatorForm viewInvigilator=new ViewInvigilatorForm();
            viewInvigilator.MdiParent= this;
            viewInvigilator.Show();
        }

        private void viewExamRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOpenedForms();
            ViewExamRoomForm viewExamRoom=new ViewExamRoomForm();
            viewExamRoom.MdiParent= this;
            viewExamRoom.Show();
        }

        private void CloseOpenedForms()
        {
            //Close any open forms
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        } //CloseOpenedForms() end
    }
}
