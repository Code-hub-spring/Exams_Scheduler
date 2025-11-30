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
    public partial class ViewInvigilatorForm : Form
    {
        static ViewInvigilatorForm instance;
        InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();
        public ViewInvigilatorForm()
        {
            InitializeComponent();
        }
        public static ViewInvigilatorForm GetViewInvigilatorFormInstance()
        {
            //This method returns an instance of ViewInvigilatorForm, only if the instance is null.
            if (instance == null || instance.IsDisposed)
            {
                instance = new ViewInvigilatorForm();
            }
            return instance;
        }
        private void ViewInvigilatorForm_Close(object sender, FormClosedEventArgs e)
        {
            //When the form is closed, set the instance to null so that it can be created again.
            instance = null;
        }
        private void ViewInvigilatorForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = invigilatorIntermediary.GetAllInvigilators();
                if (dt != null && dt.Rows.Count > 0)
                {
                    viewInvigilatorDataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Invigilators found.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Invigilators:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewInvigilatorDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (viewInvigilatorDataGridView.Columns[e.ColumnIndex].Name =="Available")
            {
                try
                {
                    int invId = Convert.ToInt32(viewInvigilatorDataGridView.Rows[e.RowIndex].Cells["InvigilatorID"].Value);
                    bool invAvailability = Convert.ToBoolean(viewInvigilatorDataGridView.Rows[e.RowIndex].Cells["Available"].Value);

                    bool updated = invigilatorIntermediary.UpdateInvigilatorAvailability(invId, invAvailability);
                    if (updated)
                    {
                        MessageBox.Show("Invigilator availability updated.",
                           "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Failed.",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

