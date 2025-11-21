using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.IntermediaryClasses;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class BookExamRoomForm : Form
    {
        private ExamScheduleInterMediarycs examIntermediary = new ExamScheduleInterMediarycs();
        private RoomIntermediary roomIntermediary = new RoomIntermediary();
        private InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();
        private CoursesIntermediary courseIntermediary = new CoursesIntermediary();

        // base exam duration in hours (change if needed)
        private const int BaseExamHours = 2;

        public BookExamRoomForm()
        {
            InitializeComponent();

        }

        private void BookExamRoomForm_Load(object sender, EventArgs e)
        {
            //LoadCoursesFromEnum();
            LoadRoomsFromDb();
            LoadInvigilatorsFromDb();
            LoadCourseFromDB();
            //ExamDateTimePicker.Format = DateTimePickerFormat.Custom;
            //ExamDateTimePicker.CustomFormat = "yyyy-MM-dd";
            //ExamDateTimePicker.ShowUpDown = true;

            ExamStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            ExamStartDateTimePicker.CustomFormat = "HH:mm";
            ExamStartDateTimePicker.ShowUpDown = true;

            ExamEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            ExamEndDateTimePicker.CustomFormat = "HH:mm";
            ExamEndDateTimePicker.ShowUpDown = true;

            SpecialPermGroupBox.Enabled = false;          // special permission details off by default
            TotalExamHoursLabel.Text = "-";     // initial label
            RoomCapacityTextBox.ReadOnly = true;           // capacity readonly

            // events
            RoomComboBox.SelectedIndexChanged += RoomComboBox_SelectedIndexChanged;
            SpecialPermissionCheckBox.CheckedChanged += SpecialPermissionCheckBox_CheckedChanged;
            ScheduleButton.Click += ScheduleButton_Click;
        }

        // 1) Courses from Enum
        //private void LoadCoursesFromEnum()
        //{
        //    CourseComboBox.DataSource = Enum.GetValues(typeof(EnumData))
        //                            .Cast<EnumData>()
        //                            .Select(v => new
        //                            {
        //                                Value = v,
        //                                Text = EnumHelper.GetDescription(v)
        //                            })
        //                            .ToList();

        //    CourseComboBox.DisplayMember = "Text";  
        //    CourseComboBox.ValueMember = "Value";
        //}

        private void LoadCourseFromDB()
        {
            DataTable dataTable = courseIntermediary.ListCourses();
            if (dataTable != null)
            {
                CourseComboBox.DataSource = dataTable;
                CourseComboBox.DisplayMember = "CourseName";
                CourseComboBox.ValueMember = "CourseID";
            }
        }
        // 2) Rooms from DB
        private void LoadRoomsFromDb()
        {
            DataTable dt = roomIntermediary.ListRooms();
         
            if (dt != null)
            {
                RoomComboBox.DataSource = dt;
                RoomComboBox.DisplayMember = "RoomName";
                RoomComboBox.ValueMember = "RoomID";
            }
        }

        // 3) Invigilators from DB
        private void LoadInvigilatorsFromDb()
        {
            DataTable dt = invigilatorIntermediary.GetAllInvigilators();
            if (dt != null)
            {

                InvigilatorComboBox.DataSource = dt;
                InvigilatorComboBox.DisplayMember = "Name";
                InvigilatorComboBox.ValueMember = "InvigilatorID";
            }
        }

        // When room changes → fill capacity
        private void RoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomComboBox.SelectedValue == null)
                return;

            int roomId;
            if (int.TryParse(RoomComboBox.SelectedValue.ToString(), out roomId))
            {
                int capacity = roomIntermediary.GetRoomCapacity(roomId);
                RoomCapacityTextBox.Text = capacity.ToString();
            }
        }

       
        private void ClearForm()
        {
            CourseComboBox.SelectedIndex = -1;
            RoomComboBox.SelectedIndex = -1;
            InvigilatorComboBox.SelectedIndex = -1;
            RoomCapacityTextBox.Clear();
            ExamDateTimePicker.Value = DateTime.Now;
            SpecialPermissionCheckBox.Checked = false;
            TotalExamHoursLabel.Text = "-";
        }
      /// <summary>
      /// /Schedule The Exam Room
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (ExamTitleTextBox.Text==null || CourseComboBox.SelectedItem == null ||
                RoomComboBox.SelectedValue == null ||
                InvigilatorComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select course, room and invigilator.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(RoomComboBox.SelectedValue);
            int invigilatorId = Convert.ToInt32(InvigilatorComboBox.SelectedValue);
            int courseId = Convert.ToInt32(CourseComboBox.SelectedValue);
            String courseName = CourseComboBox.Text;
          //  MessageBox.Show(courseName, "====");

            // validation
            int extraHours = 0;

            if (SpecialPermissionCheckBox.Checked)
            {
                if (!int.TryParse(ExtraHoursTextBox.Text, out extraHours))
                {
                    MessageBox.Show("Please enter valid extra hours (number).",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StudentNameTextBox.Text))
                {
                    MessageBox.Show("Please enter student name for special permission.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //calculate the duration
            DateTime startTime = ExamStartDateTimePicker.Value;
            DateTime endTime = ExamEndDateTimePicker.Value;

            TimeSpan duration = endTime - startTime;

            if (duration.TotalMinutes <= 0)
            {
                MessageBox.Show("End time must be greater than Start time.",
                    "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add extra hours if required
            if (SpecialPermissionCheckBox.Checked && extraHours > 0)
            {
                duration = duration.Add(TimeSpan.FromHours(extraHours));
            }

            // Update UI display
            TotalExamHoursLabel.Text = duration.TotalHours.ToString("0.##") + " hours";
           string examTitle = ExamTitleTextBox.Text;
           // Convert to minutes for DB
            int totalMinutes = (int)duration.TotalMinutes;
// create exam object
            Exam exam = new Exam
            {
                ExamTitle =examTitle,
                CourseID = courseId,
                CourseName=courseName,
                RoomID = roomId,
                InvigilatorID = invigilatorId,
                ExamDateTime = ExamDateTimePicker.Value,
                ExamStartTime = startTime,
                ExamEndTime = endTime,
                DurationMinutes = totalMinutes,
                SpecialPermission = SpecialPermissionCheckBox.Checked,
                SpecialStudentName = SpecialPermissionCheckBox.Checked
                                        ? StudentNameTextBox.Text.Trim()
                                        : null,
                ExtraHours = extraHours
            };
            //save to DB
            try
            {
                int result = examIntermediary.InsertExam(exam);

                if (result > 0)
                {
                    // Mark room & invigilator not available
                    roomIntermediary.UpdateRoomAvailability(roomId, false);
                    invigilatorIntermediary.UpdateInvigilatorAvailability(invigilatorId, false);

                    MessageBox.Show("Exam scheduled successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to schedule exam.\n" + examIntermediary.LastError,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Special permission checkbox
        private void SpecialPermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SpecialPermGroupBox.Enabled = SpecialPermissionCheckBox.Checked;
            if (!SpecialPermissionCheckBox.Checked)
            {
                StudentNameTextBox.Clear(); // student name
                ExtraHoursTextBox.Clear(); // extra hours
            }
        }

        private void SpecialPermGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
