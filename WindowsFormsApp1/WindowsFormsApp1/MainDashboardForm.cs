using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        //private void addExamToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    AddExamRoomForm addExamRoomForm = new AddExamRoomForm();
        //}

        private void addInvigitatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInvigilatorForm addInvigilatorForm = new AddInvigilatorForm();
        }

        private void bookTheExamRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookExamRoomForm bookExamRoomForm = new BookExamRoomForm();
        }

        private void viewAllSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExamScheduleDetailsForm viewExamScheduleDetailsForm = new ViewExamScheduleDetailsForm();
        }
    }
}
