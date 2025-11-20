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

        public ExamCancelForm()
        {
            InitializeComponent();
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
                //EnumData courseEnum = (EnumData)courseId;
                //CourseNameTextBox.Text = EnumHelper.GetDescription(courseEnum);
                CourseNameTextBox.Text = exam["CourseName"].ToString();
                RoomNameTextBox.Text = exam["RoomName"].ToString();
                InvigilatorNameTextBox.Text = exam["Name"].ToString();

                ExamDateTextBox.Text = Convert.ToDateTime(exam["ExamDate"]).ToString("yyyy-MM-dd");

                textBox5.Text = exam["ExamStartTime"].ToString();
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

            // DELETE
            int result = examIM.DeleteExam(examId);

            if (result > 0)
            {
                roomIM.UpdateRoomAvailability(roomId, true);
                invIM.UpdateInvigilatorAvailability(invId, true);

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
            textBox5.Text = "";
            EndTimeTextBox.Text = "";
        }
    }
}
