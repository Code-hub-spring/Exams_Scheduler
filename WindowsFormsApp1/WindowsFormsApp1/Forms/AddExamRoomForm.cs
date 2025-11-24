using System;
using System.Windows.Forms;
using WindowsFormsApp1.IntermediaryClasses;

namespace WindowsFormsApp1
{
    public partial class AddExamRoomForm : Form
    {
        internal static AddExamRoomForm addExamRoomInstance;
        RoomIntermediary roomIntermediary = new RoomIntermediary();

        public AddExamRoomForm()
        {
            InitializeComponent();
        }
        internal static AddExamRoomForm GetAddExamRoomFormInstance()
        {
            //This method returns an instance of AddExamRoomForm, only if the instance is null.
            if (addExamRoomInstance == null)
            {
                addExamRoomInstance = new AddExamRoomForm();
            }
            return addExamRoomInstance;
        }
        private void AddExamRoomFormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form closes, make the instance null, so the form loads again when called the second time.
            addExamRoomInstance = null;
        } //AddExamRoomFormClosing() end
         
        private void AddExamRoomForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string roomName = RoomNameTextBox.Text.Trim();
                // VALIDATION
                if (RoomNumTextBox.Text!="")
                {
                    if(int.TryParse(RoomNumTextBox.Text, out int roomNumber))
                    {
                        if (roomName != "")
                        {
                            if (int.TryParse(RoomCapacityTextBox.Text, out int roomCapacity))
                            {
                                // CALL INTERMEDIARY CLASS
                                int result = roomIntermediary.AddRoom(roomNumber, roomName, roomCapacity);
                                if (result > 0)
                                {
                                    MessageBox.Show("Room added successfully!");
                                    ClearForm();
                                }
                                else
                                {
                                    MessageBox.Show("Error: " + roomIntermediary.LastError);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Room Capacity must be a valid number.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Room Name cannot be empty.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Number must be a valid number.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Room Number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            RoomNumTextBox.Clear();
            RoomCapacityTextBox.Clear();
            RoomNumTextBox.Focus();
        }
    }
}
