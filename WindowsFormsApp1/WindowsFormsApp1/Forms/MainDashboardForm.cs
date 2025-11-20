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
            AddInvigilatorForm addInvigilatorForm = new AddInvigilatorForm();
            addInvigilatorForm.MdiParent = this;
            addInvigilatorForm.Show();
        }

        private void bookTheExamRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookExamRoomForm bookExamRoomForm = new BookExamRoomForm();
            bookExamRoomForm.MdiParent = this;
            bookExamRoomForm.Show();
        }

        private void viewAllSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExamScheduleDetailsForm viewExamScheduleDetailsForm = new ViewExamScheduleDetailsForm();
            viewExamScheduleDetailsForm.MdiParent= this;
            viewExamScheduleDetailsForm.Show();
        }

        private void addExamRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExamRoomForm addExamRoom=new AddExamRoomForm();
            addExamRoom.MdiParent= this;
            addExamRoom.Show();
        }

        private void cancelTheScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamCancelForm examCancelForm = new ExamCancelForm();
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
            EditExamForm editExam=new EditExamForm();
            editExam.MdiParent= this;
            editExam.Show();
        }

        private void viewInvigilatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInvigilatorForm viewInvigilator=new ViewInvigilatorForm();
            viewInvigilator.MdiParent= this;
            viewInvigilator.Show();
        }

        private void viewExamRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExamRoomForm viewExamRoom=new ViewExamRoomForm();
            viewExamRoom.MdiParent= this;
            viewExamRoom.Show();
        }
    }
}
