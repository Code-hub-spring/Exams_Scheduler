using System;
using System.Windows.Forms;
using WindowsFormsApp1.IntermediaryClasses;

namespace WindowsFormsApp1
{
    public partial class AddExamRoomForm : Form
    {
        RoomIntermediary roomIntermediary = new RoomIntermediary();

        public AddExamRoomForm()
        {
            InitializeComponent();
        }

        private void AddExamRoomForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string roomName = RoomNameTextBox.Text.Trim();
                // VALIDATION
                if (string.IsNullOrWhiteSpace(RoomNumTextBox.Text) ||
                    string.IsNullOrWhiteSpace(RoomCapacityTextBox.Text))
                {
                    MessageBox.Show("Please enter valid details for both fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(RoomNumTextBox.Text, out int roomNumber))
                {
                    MessageBox.Show("Room Number must be a valid number.");
                    return;
                }

                if(roomName == "")
                {
                    MessageBox.Show("Room Name cannot be string");
                }
                if (!int.TryParse(RoomCapacityTextBox.Text, out int roomCapacity))
                {
                    MessageBox.Show("Room Capacity must be a valid number.");
                    return;
                }

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
