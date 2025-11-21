using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
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

        int SelectedExamID = 0;
        int BaseDuration = 2; // default 2 hours

        public EditExamForm()
        {
            InitializeComponent();
        }

        private void EditExamForm_Load(object sender, EventArgs e)
        {
            LoadExamList();
            LoadCourses();
            LoadRooms();
            LoadInvigilators();

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
            //CourseComboBox.DataSource = Enum.GetValues(typeof(EnumData))
            //    .Cast<EnumData>()
            //    .Select(e => new
            //    {
            //        Value = e,
            //        Text = GetDescription(e)
            //    })
            //    .ToList();

            //CourseComboBox.DisplayMember = "Text";
            //CourseComboBox.ValueMember = "Value";
            DataTable dt = coursesIM.ListCourses();
          
             CourseComboBox.DisplayMember = "CourseName";
            CourseComboBox.ValueMember = "CourseID";
            CourseComboBox.DataSource = dt;
        }

        private void LoadRooms()
        {
            DataTable dt = roomIM.ListRooms();
            RoomComboBox.DisplayMember = "RoomName";
            RoomComboBox.ValueMember = "RoomID";
            RoomComboBox.DataSource = dt;
        }

        private void LoadInvigilators()
        {
            DataTable dt = invIM.GetAllInvigilators();
            InvigilatorComboBox.DisplayMember = "Name";
            InvigilatorComboBox.ValueMember = "InvigilatorID";
            InvigilatorComboBox.DataSource = dt;
        }


// on change of combo box

        private void cmbExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExamListComboBox.SelectedValue == null || ExamListComboBox.SelectedIndex == -1)
                return;

            SelectedExamID = Convert.ToInt32(ExamListComboBox.SelectedValue);

            DataRow row = examIM.GetExamById(SelectedExamID);
            if (row == null)
            {
                MessageBox.Show("Could not load exam details.");
                return;
            }

            CourseComboBox.SelectedValue = Convert.ToInt32(row["CourseID"]);

            RoomComboBox.SelectedValue = Convert.ToInt32(row["RoomID"]);
            InvigilatorComboBox.SelectedValue = Convert.ToInt32(row["InvigilatorID"]);

            DateTime date = Convert.ToDateTime(row["ExamDate"]);
            TimeSpan startTime = (TimeSpan)row["ExamStartTime"];
            TimeSpan endTime = (TimeSpan)row["ExamEndTime"];
            // MessageBox.Show(startTime.ToString());
            ExamDateTime.Value = date;
           
            DateTime combinedStartDateTime = date.Date + startTime;
            StartTimedateTimePicker.Value = combinedStartDateTime;
            StartTimedateTimePicker.Value = ExamDateTime.Value.Date + startTime;

            DateTime combinedEndDateTime = date.Date + endTime;
            EndTimeDateTimePicker.Value = combinedEndDateTime;
            EndTimeDateTimePicker.Value = ExamDateTime.Value.Date + endTime;


            // check column exists before reading
            chkSpecial.Checked = row.Table.Columns.Contains("SpecialNeeds")
                ? Convert.ToBoolean(row["SpecialNeeds"])
                : false;

            StudentNameTextBox.Text = row.Table.Columns.Contains("SpecialStudentName")
                ? row["SpecialStudentName"].ToString()
                : "";

            ExtraHoursTextBox.Text = row.Table.Columns.Contains("ExtraHours")
                ? row["ExtraHours"].ToString()
                : "0";

            grpSpecial.Enabled = chkSpecial.Checked;
            UpdateDuration();
        }


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

        private void UpdateDuration()
        {
            int extra = 0;
            int.TryParse(ExtraHoursTextBox.Text, out extra);

            lblDuration.Text = $"{BaseDuration + extra} Hours";
        }


    // update the exam data

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedExamID == 0)
            {
                MessageBox.Show("Select an exam first.");
                return;
            }

            int extraHours = chkSpecial.Checked ? int.Parse(ExtraHoursTextBox.Text) : 0;

            Exam exam = new Exam
            {
               // CourseID = cmbCourse.SelectedValue, 
                RoomID = Convert.ToInt32(RoomComboBox.SelectedValue),
                InvigilatorID = Convert.ToInt32(InvigilatorComboBox.SelectedValue),
                ExamDateTime = ExamDateTime.Value,
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       //description helper

        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attr = field.GetCustomAttribute<DescriptionAttribute>();
            return attr?.Description ?? value.ToString();
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
