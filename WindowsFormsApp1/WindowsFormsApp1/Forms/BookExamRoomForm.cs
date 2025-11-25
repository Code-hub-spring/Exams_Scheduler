using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.IntermediaryClasses;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1
{
    public partial class BookExamRoomForm : Form
    {
        private ExamScheduleInterMediarycs examIntermediary = new ExamScheduleInterMediarycs();
        private RoomIntermediary roomIntermediary = new RoomIntermediary();
        private InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();
        private CoursesIntermediary courseIntermediary = new CoursesIntermediary();
        private ScheduledExamDerived scheduledExam = new ScheduledExamDerived();
        internal static BookExamRoomForm instance;
        private string examType;
        private const int BaseExamHours = 2;

        public BookExamRoomForm()
        {
            InitializeComponent();

        }
        internal static BookExamRoomForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BookExamRoomForm();
            }
            return instance;
        }
        private void BookExamRoomForm_Close(object sender, EventArgs e)
        {
            instance = null;
        }
        private void BookExamRoomForm_Load(object sender, EventArgs e)
        {
            //LoadCoursesFromEnum();
            LoadRoomsFromDb();
            LoadInvigilatorsFromDb();
            LoadCourseFromDB();
            ExamDateTimePicker.MinDate = DateTime.Today;    
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

        //Using generic helper to load courses from DB 
        private void LoadCourseFromDB()
        {
            DataTable dataTable = courseIntermediary.ListCourses();
            if (dataTable != null)
            {
                GenericsHelper.LoadComboBox(CourseComboBox, dataTable, "CourseName", "CourseID");
            }
        }
        //Using generic helper to load Room from DB 
        private void LoadRoomsFromDb()
        {
            DataTable dt = roomIntermediary.ListRooms();
            if (dt != null)
            {
                GenericsHelper.LoadComboBox(RoomComboBox, dt, "RoomName", "RoomID");
            }
        }

        //Using generic helper to load Invigilator from DB 
        private void LoadInvigilatorsFromDb()
        {
            DataTable dt = invigilatorIntermediary.GetAllInvigilators();
            if (dt != null)
            {
                GenericsHelper.LoadComboBox(InvigilatorComboBox, dt, "Name", "InvigilatorID");
            }
    
        }

        // When room changes, fill capacity
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

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            // Basic validation
            ExamBase exam_permission;
            if (ExamTitleTextBox.Text != "")
            {
                if (examType != "")
                {
                    if (CourseComboBox.SelectedItem.ToString() != "")
                    {
                        if (RoomComboBox.SelectedItem.ToString() != "")
                        {
                            if (InvigilatorComboBox.SelectedItem.ToString() != "")
                            {
                                string examTitle = ExamTitleTextBox.Text;
                                int roomId = Convert.ToInt32(RoomComboBox.SelectedValue);
                                int invigilatorId = Convert.ToInt32(InvigilatorComboBox.SelectedValue);
                                int courseId = Convert.ToInt32(CourseComboBox.SelectedValue);
                                String courseName = CourseComboBox.Text;
                                int extraHours = 0;
                             

                                DateTime startTime = ExamStartDateTimePicker.Value;
                                DateTime endTime = ExamEndDateTimePicker.Value;

                                if (SpecialPermissionCheckBox.Checked)
                                {
                                    if (!int.TryParse(ExtraHoursTextBox.Text, out extraHours))
                                    {
                                        MessageBox.Show("Please enter valid extra hours (number).",
                                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    else
                                    {
                                        exam_permission = new ScheduledExamDerived { ExtraHours = extraHours };
                                    }
                                    if (string.IsNullOrWhiteSpace(StudentNameTextBox.Text))
                                    {
                                        MessageBox.Show("Please enter student name for special permission.",
                                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    exam_permission = new ExamBase();
                                }
                                TimeSpan duration = exam_permission.CalculateDuration(startTime, endTime); // Call overload method if extra hours added
                                if (duration.TotalMinutes <= 0)
                                {
                                    MessageBox.Show("End time must be greater than Start time.",
                                        "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                {
                                    TotalExamHoursLabel.Text = duration.TotalHours.ToString("0.##") + " hours";
                                }
                                int totalMinutes = (int)duration.TotalMinutes;
                                ScheduledExamDerived exam = new ScheduledExamDerived
                                {
                                    ExamTitle = examTitle,
                                    ExamType = examType,
                                    CourseID = courseId,
                                    CourseName = courseName,
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
                            else
                            {
                                MessageBox.Show("Please select invigilator",
                               "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select room",
                           "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select course",
                           "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select Exam type",
                           "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter the exam title",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        private void MidTermRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
           
            switch(radioButton.Name)
            {
                case "MidTermRadioButton":
                    examType =ExamType.MidTerm.ToString();
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
    }
}
