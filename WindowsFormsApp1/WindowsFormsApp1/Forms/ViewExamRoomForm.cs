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

namespace WindowsFormsApp1.Forms
{
    public partial class ViewExamRoomForm : Form
    {
        internal static ViewExamRoomForm instance;
        RoomIntermediary roomIntermediary = new RoomIntermediary();
        public ViewExamRoomForm()
        {
            InitializeComponent();
        }
        public static ViewExamRoomForm GetViewExamRoomFormInstance()
        {
            //This method returns an instance of ViewExamRoomForm, only if the instance is null.
            if (instance == null || instance.IsDisposed)
            {
                instance = new ViewExamRoomForm();
            }
            return instance;
        }

        private void ViewExamRoomForm_Close(object sender, EventArgs e)
        {
            instance = null;
        }
        private void ViewExamRoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = roomIntermediary.ListRooms();
                if (dt != null && dt.Rows.Count > 0)
                {
                    viewExamRoomdataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No rooms found.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in rooms:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewExamRoomdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (viewExamRoomdataGridView.Columns[e.ColumnIndex].Name == "Available")
            {
                try
                {
                    int roomId = Convert.ToInt32(viewExamRoomdataGridView.Rows[e.RowIndex].Cells["RoomID"].Value);
                    bool roomAvailable = Convert.ToBoolean(viewExamRoomdataGridView.Rows[e.RowIndex].Cells["Available"].Value);
                     bool updated = roomIntermediary.UpdateRoomAvailability(roomId, roomAvailable);
                    if (updated)
                        MessageBox.Show("Room availability updated.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Failed to update.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
