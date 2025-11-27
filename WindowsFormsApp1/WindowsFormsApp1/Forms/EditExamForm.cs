using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Helpers;
using WindowsFormsApp1.IntermediaryClasses;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class EditExamForm : Form
    {
        ExamScheduleInterMediarycs examIM = new ExamScheduleInterMediarycs();
        RoomIntermediary roomIM = new RoomIntermediary();
        InvigilatorIntermediary invIM = new InvigilatorIntermediary();
        CoursesIntermediary coursesIM = new CoursesIntermediary();
        ScheduledExamDerived scheduledExam = new ScheduledExamDerived();
        private string examType;
        internal static EditExamForm instance;

        int SelectedExamID = 0;
        int BaseDuration = 2; // default 2 hours

        public EditExamForm()
        {
            InitializeComponent();
        }
        internal static EditExamForm GetEditExamFormInstance()
        {
            //This method returns an instance of EditExamForm, only if the instance is null.
            if (instance == null || instance.IsDisposed)
            {
                instance = new EditExamForm();
            }
            return instance;
        }
        private void EditExamForm_Close(object sender,EventArgs e)
        {
            instance = null;
        }
        private void EditExamForm_Load(object sender, EventArgs e)
        {
            LoadExamList();
            LoadCourses();
            LoadRooms();
            LoadInvigilators();

            StartTimedateTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimedateTimePicker.CustomFormat = "HH:mm";
            StartTimedateTimePicker.ShowUpDown = true;

            EndTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimeDateTimePicker.CustomFormat = "HH:mm";
            EndTimeDateTimePicker.ShowUpDown = true;

            // Disable past dates in Exam Date
            ExamDateTime.MinDate = DateTime.Today;

            grpSpecial.Enabled = false;
             ExamListComboBox.SelectedIndexChanged += cmbExamList_SelectedIndexChanged;
            RoomComboBox.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            chkSpecial.CheckedChanged += chkSpecial_CheckedChanged;
        }
        // load exam list
        private void LoadExamList()
        {
            DataTable dt = examIM.SelectExams();
    
            ExamListComboBox.DisplayMember = "ExamTitle";
            ExamListComboBox.ValueMember = "ExamID";
            ExamListComboBox.DataSource = dt;

        }
        private void LoadCourses()
        {
            DataTable dt = coursesIM.ListCourses();
            //CourseComboBox.DisplayMember = "CourseName";
            //CourseComboBox.ValueMember = "CourseID";
            //CourseComboBox.DataSource = dt;
            if (dt != null)
            {
                GenericsHelper.LoadComboBox(CourseComboBox, dt, "CourseName", "CourseID");
            }
        }
        private void LoadRooms()
        {
            DataTable dt = roomIM.ListRooms(true);
            //RoomComboBox.DisplayMember = "RoomName";
            //RoomComboBox.ValueMember = "RoomID";
            //RoomComboBox.DataSource = dt;
            if (dt != null)
            {
                GenericsHelper.LoadComboBox(RoomComboBox, dt, "RoomName", "RoomID");
            }
        }

        private void LoadInvigilators()
        {
            DataTable dt = invIM.GetAllInvigilators(true);
            //InvigilatorComboBox.DisplayMember = "Name";
            //InvigilatorComboBox.ValueMember = "InvigilatorID";
            //InvigilatorComboBox.DataSource = dt;
            if (dt != null)
            {
                GenericsHelper.LoadComboBox(InvigilatorComboBox, dt, "Name", "InvigilatorID");
            }
        }
// on change of combo box

        private void cmbExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamBase exam_permission;
            if (ExamListComboBox.SelectedValue == null || ExamListComboBox.SelectedIndex == -1)
                return;

            SelectedExamID = Convert.ToInt32(ExamListComboBox.SelectedValue);
            DataRow row = examIM.GetExamById(SelectedExamID);
            if (row == null)
            {
                MessageBox.Show("Could not load exam details.");
                return;
            }
            string type = row["ExamType"].ToString().Trim();
            switch (type)
            {
                case "MidTerm":
                    MidTermRadioButton.Checked = true;
                    break;
                case "Final":
                    FinalRadioButton.Checked = true;
                    break;
                case "Retake":
                    RetakeRadioButton.Checked = true;
                    break;
                case "Special":
                    SpecialRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
            CourseComboBox.SelectedValue = Convert.ToInt32(row["CourseID"]);
            RoomComboBox.SelectedValue = Convert.ToInt32(row["RoomID"]);
            txtCapacity.Text = row["Capacity"].ToString();
            InvigilatorComboBox.SelectedValue = Convert.ToInt32(row["InvigilatorID"]);
            // Read exam date and times
            DateTime date = Convert.ToDateTime(row["ExamDate"]);
            TimeSpan startTS = (TimeSpan)row["ExamStartTime"];
            TimeSpan endTS = (TimeSpan)row["ExamEndTime"];
            // Set date
            DateTime startDateTime = date.Date.Add(startTS);
            DateTime endDateTime = date.Date.Add(endTS);

            StartTimedateTimePicker.Value = startDateTime;
            EndTimeDateTimePicker.Value = endDateTime;

            int extraHours = row["ExtraHours"] != DBNull.Value
        ? Convert.ToInt32(row["ExtraHours"]): 0;
            ExtraHoursTextBox.Text = extraHours.ToString();

            TimeSpan duration = TimeSpan.FromMinutes(Convert.ToInt32(row["DurationMinutes"]));
            lblDuration.Text = duration.TotalHours.ToString("0.##") + " hours";

            // check column exists before reading
            chkSpecial.Checked = row.Table.Columns.Contains("SpecialNeeds")
                ? Convert.ToBoolean(row["SpecialNeeds"])
                : false;
            StudentNameTextBox.Text = row.Table.Columns.Contains("SpecialStudentName")
                ? row["SpecialStudentName"].ToString()
                : "";
            grpSpecial.Enabled = chkSpecial.Checked;
           // UpdateDuration();
            }
       // }
         //auto load of room capacity
        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomComboBox.SelectedValue != null)
            {
                int roomId = Convert.ToInt32(RoomComboBox.SelectedValue);
                txtCapacity.Text = roomIM.GetRoomCapacity(roomId).ToString();
            }
        }
        //check for spl permission
        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            grpSpecial.Enabled = chkSpecial.Checked;
            if (!chkSpecial.Checked)
            {
                StudentNameTextBox.Clear();
                ExtraHoursTextBox.Clear();
            }
        }
        //calculate the total hpurs for exam
        //private void UpdateDuration()
        //{
        //    int extra = 0;
        //    int.TryParse(ExtraHoursTextBox.Text, out extra);
        //    lblDuration.Text = $"{BaseDuration + extra} Hours";
        //}
    // update the exam data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedExamID == 0)
            {
                MessageBox.Show("Select an exam first.");
                return;
            }

            if (EndTimeDateTimePicker.Value <= StartTimedateTimePicker.Value)
            {
                lblDuration.Text = "Invalid Time";
                EndTimeDateTimePicker.Value = StartTimedateTimePicker.Value.AddMinutes(30);
                MessageBox.Show("End time must be greater than Start time.", "Invalid Time",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                int extraHours = chkSpecial.Checked ? int.Parse(ExtraHoursTextBox.Text) : 0;
                ScheduledExamDerived exam = new ScheduledExamDerived
                {
                    // CourseID = cmbCourse.SelectedValue, 
                    RoomID = Convert.ToInt32(RoomComboBox.SelectedValue),
                    InvigilatorID = Convert.ToInt32(InvigilatorComboBox.SelectedValue),
                    ExamDateTime = ExamDateTime.Value,
                    ExamType = examType,
                    ExamStartTime = StartTimedateTimePicker.Value,
                    ExamEndTime = EndTimeDateTimePicker.Value,
                    DurationMinutes = (BaseDuration + extraHours) * 60,
                    CourseID = Convert.ToInt32(CourseComboBox.SelectedValue),
                    SpecialPermission = chkSpecial.Checked,
                    SpecialStudentName = chkSpecial.Checked ? StudentNameTextBox.Text.Trim() : null,
                    ExtraHours = extraHours
                };

                int result = examIM.UpdateExam(exam, SelectedExamID);
                if (result > 0)
                    MessageBox.Show("Exam Updated Successfully!");
                else
                    MessageBox.Show("Error: " + examIM.LastError);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       //description helper
        private void MidTermRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "MidTermRadioButton":
                    examType = ExamType.MidTerm.ToString();
                    break;
                case "FinalRadioButton":
                    examType = ExamType.Final.ToString();
                    break;
                case "RetakeRadioButton":
                    examType = ExamType.Retake.ToString(); ;
                    break;
                case "SpecialRadioButton":
                    examType = ExamType.Special.ToString(); ;
                    break;
                default:
                    examType = "";
                    break;
            }
        }

        private void StartTimedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDateTime = ExamDateTime.Value.Date.Add(StartTimedateTimePicker.Value.TimeOfDay);
            DateTime endDateTime = ExamDateTime.Value.Date.Add(EndTimeDateTimePicker.Value.TimeOfDay);

           // Read extra hours
            int extraHours = 0;
            int.TryParse(ExtraHoursTextBox.Text, out extraHours);

            // Create correct exam object (polymorphism)
            ExamBase exam_permission;
            if (chkSpecial.Checked && extraHours > 0)
                exam_permission = new ScheduledExamDerived { ExtraHours = extraHours };
            else
                exam_permission = new ExamBase();

            // Calculate duration
            TimeSpan duration = exam_permission.CalculateDuration(startDateTime, endDateTime);
            // Validate
            if (duration.TotalMinutes <= 0)
            {
                lblDuration.Text = "Invalid Time";
                return;
            }
            // Display duration
            lblDuration.Text = duration.TotalHours.ToString("0.##") + " Hours";
        }

    }
}
