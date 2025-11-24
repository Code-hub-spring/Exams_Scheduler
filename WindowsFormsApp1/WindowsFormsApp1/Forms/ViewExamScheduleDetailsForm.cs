using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.IntermediaryClasses;

namespace WindowsFormsApp1
{
    public partial class ViewExamScheduleDetailsForm : Form
    {
        internal static ViewExamScheduleDetailsForm instance;
        public ViewExamScheduleDetailsForm()
        {
            InitializeComponent();
        }

        internal static ViewExamScheduleDetailsForm GetViewExamScheduleDetailsFormInstance()
        {
            //This method returns an instance of ViewExamScheduleDetailsForm, only if the instance is null.
            if (instance == null)
            {
                instance = new ViewExamScheduleDetailsForm();
            }
            return instance;
        }
        private void ViewExamScheduleDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                ExamScheduleInterMediarycs examScheduleInterMediarycs = new ExamScheduleInterMediarycs();

                DataTable dt = examScheduleInterMediarycs.SelectExams();

                if (dt != null && dt.Rows.Count > 0)
                {
                    ExamScheduleDataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No exam records found.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exam schedule:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
