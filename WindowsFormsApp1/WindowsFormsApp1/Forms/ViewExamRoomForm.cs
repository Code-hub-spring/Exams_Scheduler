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
        public ViewExamRoomForm()
        {
            InitializeComponent();
        }
        public static ViewExamRoomForm GetViewExamRoomFormInstance()
        {
            //This method returns an instance of ViewExamRoomForm, only if the instance is null.
            if (instance == null)
            {
                instance = new ViewExamRoomForm();
            }
            return instance;
        }
        private void ViewExamRoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                RoomIntermediary roomIntermediary = new RoomIntermediary();


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
    }
}
