using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.IntermediaryClasses;
using WindowsFormsApp1.Models;
using System.ComponentModel;
using System.Reflection;

namespace WindowsFormsApp1.Forms
{
    public partial class EditExamForm : Form
    {
        ExamScheduleInterMediarycs examIM = new ExamScheduleInterMediarycs();
        RoomIntermediary roomIM = new RoomIntermediary();
        InvigilatorIntermediary invIM = new InvigilatorIntermediary();

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

            cmbExamList.SelectedIndexChanged += cmbExamList_SelectedIndexChanged;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            chkSpecial.CheckedChanged += chkSpecial_CheckedChanged;
        }

        // ===============================================
        // LOAD DATA
        // ===============================================

        private void LoadExamList()
        {
            DataTable dt = examIM.SelectExams();
          
            cmbExamList.DisplayMember = "ExamID";
            cmbExamList.ValueMember = "ExamID";
            cmbExamList.DataSource = dt;

        }

        private void LoadCourses()
        {
            cmbCourse.DataSource = Enum.GetValues(typeof(EnumData))
                .Cast<EnumData>()
                .Select(e => new
                {
                    Value = e,
                    Text = GetDescription(e)
                })
                .ToList();

            cmbCourse.DisplayMember = "Text";
            cmbCourse.ValueMember = "Value";
        }

        private void LoadRooms()
        {
            DataTable dt = roomIM.ListRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.DataSource = dt;
        }

        private void LoadInvigilators()
        {
            DataTable dt = invIM.GetAllInvigilators();
            cmbInvigilator.DisplayMember = "Name";
            cmbInvigilator.ValueMember = "InvigilatorID";
            cmbInvigilator.DataSource = dt;
        }


        // ===============================================
        // LOAD SELECTED EXAM DETAILS  ⭐ CORE FUNCTION
        // ===============================================

        private void cmbExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExamList.SelectedValue == null || cmbExamList.SelectedIndex == -1)
                return;

            SelectedExamID = Convert.ToInt32(cmbExamList.SelectedValue);

            DataRow row = examIM.GetExamById(SelectedExamID);
            if (row == null)
            {
                MessageBox.Show("Could not load exam details.");
                return;
            }

            // ⭐ FIXED — check column exists
            int courseId = Convert.ToInt32(row["CourseID"]);
            EnumData courseEnum = (EnumData)courseId;
            cmbCourse.SelectedValue = EnumHelper.GetDescription(courseEnum);
           
            cmbRoom.SelectedValue = Convert.ToInt32(row["RoomID"]);
            cmbInvigilator.SelectedValue = Convert.ToInt32(row["InvigilatorID"]);

            // ⭐ FIXED — some DBs store date & time as separate fields
            DateTime date = Convert.ToDateTime(row["ExamDate"]);
            TimeSpan startTime = (TimeSpan)row["ExamStartTime"];
            dtExam.Value = date.Add(startTime);

            // ⭐ FIXED — check column exists before reading
            chkSpecial.Checked = row.Table.Columns.Contains("SpecialNeeds")
                ? Convert.ToBoolean(row["SpecialNeeds"])
                : false;

            txtStudentName.Text = row.Table.Columns.Contains("SpecialStudentName")
                ? row["SpecialStudentName"].ToString()
                : "";

            txtExtraHours.Text = row.Table.Columns.Contains("ExtraHours")
                ? row["ExtraHours"].ToString()
                : "0";

            grpSpecial.Enabled = chkSpecial.Checked;

            UpdateDuration();
        }


        // ===============================================
        // ROOM CAPACITY AUTO UPDATE
        // ===============================================

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedValue != null)
            {
                int roomId = Convert.ToInt32(cmbRoom.SelectedValue);
                txtCapacity.Text = roomIM.GetRoomCapacity(roomId).ToString();
            }
        }


        // ===============================================
        // SPECIAL PERMISSION TOGGLE
        // ===============================================

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            grpSpecial.Enabled = chkSpecial.Checked;

            if (!chkSpecial.Checked)
            {
                txtStudentName.Clear();
                txtExtraHours.Clear();
            }
        }


        // ===============================================
        // UPDATE DURATION
        // ===============================================

        private void UpdateDuration()
        {
            int extra = 0;
            int.TryParse(txtExtraHours.Text, out extra);

            lblDuration.Text = $"{BaseDuration + extra} Hours";
        }


        // ===============================================
        // UPDATE EXAM  ⭐ IMPORTANT
        // ===============================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedExamID == 0)
            {
                MessageBox.Show("Select an exam first.");
                return;
            }

            int extraHours = chkSpecial.Checked ? int.Parse(txtExtraHours.Text) : 0;

            Exam exam = new Exam
            {
               // CourseID = cmbCourse.SelectedValue, // ⭐ FIXED
                RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                InvigilatorID = Convert.ToInt32(cmbInvigilator.SelectedValue),
                ExamDateTime = dtExam.Value,
                ExamStartTime = StartTimedateTimePicker.Value,
                ExamEndTime = EndTimeDateTimePicker.Value,
                DurationMinutes = (BaseDuration + extraHours) * 60,

                SpecialPermission = chkSpecial.Checked,
                SpecialStudentName = chkSpecial.Checked ? txtStudentName.Text.Trim() : null,
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


        // ===============================================
        // ENUM DESCRIPTION HELPER
        // ===============================================

        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attr = field.GetCustomAttribute<DescriptionAttribute>();
            return attr?.Description ?? value.ToString();
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }
    }
}
