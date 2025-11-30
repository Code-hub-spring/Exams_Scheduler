using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.IntermediaryClasses;

namespace WindowsFormsApp1.Forms
{
    public partial class ExamCancelForm : Form
    {
        ExamScheduleInterMediarycs examIM = new ExamScheduleInterMediarycs();
        RoomIntermediary roomIM = new RoomIntermediary();
        InvigilatorIntermediary invIM = new InvigilatorIntermediary();
        internal static ExamCancelForm instance;

        public ExamCancelForm()
        {
            InitializeComponent();
        }
        internal static ExamCancelForm GetExamCancelFormInstance()
        {
            //This method returns an instance of ExamCancelForm, only if the instance is null.
            if (instance == null || instance.IsDisposed)
            {
                instance = new ExamCancelForm();
            }
            return instance;
        }

        private void ExamCancelForm_Close(object sender, EventArgs e)
        {
            instance = null;
        }
        private void ExamCancelForm_Load(object sender, EventArgs e)
        {
            LoadExamIDs();
            ExamIdComboBox.SelectedIndexChanged += ExamIdComboBox_SelectedIndexChanged;
            CancelExamButton.Click += CancelExamButton_Click;
        }

        // LOAD EXAM ID LIST
        private void LoadExamIDs()
        {
            DataTable dt = examIM.SelectExamIDs();
            ExamIdComboBox.DataSource = dt;
            ExamIdComboBox.DisplayMember = "ExamTitle";
            ExamIdComboBox.ValueMember = "ExamID";
        }
        // WHEN USER SELECTS AN EXAM
        private void ExamIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExamIdComboBox.SelectedValue == null) return;

            int examId = Convert.ToInt32(ExamIdComboBox.SelectedValue);
            DataRow exam = examIM.GetExamById(examId);
          
            if (exam != null)
            {
                int courseId = Convert.ToInt32(exam["CourseID"]);
                CourseNameTextBox.Text = exam["CourseName"].ToString();
                RoomNameTextBox.Text = exam["RoomName"].ToString();
                InvigilatorNameTextBox.Text = exam["InvigilatorName"].ToString();
                ExamDateTextBox.Text = Convert.ToDateTime(exam["ExamDate"]).ToString("yyyy-MM-dd");

                startTimeTextBox.Text = exam["ExamStartTime"].ToString();
                EndTimeTextBox.Text = exam["ExamEndTime"].ToString();
            }
        }

        // CANCEL EXAM BUTTON CLICK
        private void CancelExamButton_Click(object sender, EventArgs e)
        {
            if (ExamIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Select an Exam to cancel!", "Warning");
                return;
            }
            int examId = Convert.ToInt32(ExamIdComboBox.SelectedValue);
            DataRow exam = examIM.GetExamById(examId);
           
            if (exam == null)
            {
                MessageBox.Show("Cannot fetch exam details.", "Error");
                return;
            }
            int roomId = Convert.ToInt32(exam["RoomID"]);
            int invId = Convert.ToInt32(exam["InvigilatorID"]);

            // Call DeleteExam method which calls the stored procedure
            int result = examIM.DeleteExam(examId, roomId, invId);
            if (result >= 0)
            {
                MessageBox.Show("Exam cancelled successfully!", "Success");
                ClearForm();
                LoadExamIDs();
            }
            else
            {
                MessageBox.Show("Failed to cancel exam.", "Error");
            }
        }

        private void ClearForm()
        {
            CourseNameTextBox.Text = "";
            RoomNameTextBox.Text = "";
            InvigilatorNameTextBox.Text = "";
            ExamDateTextBox.Text = "";
            startTimeTextBox.Text = "";
            EndTimeTextBox.Text = "";
        }
    }
}
