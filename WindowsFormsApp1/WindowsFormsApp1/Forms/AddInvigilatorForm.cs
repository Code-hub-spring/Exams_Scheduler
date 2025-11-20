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

namespace WindowsFormsApp1
{
    public partial class AddInvigilatorForm : Form
    {
        InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();
        public AddInvigilatorForm()
        {
            InitializeComponent();
            Text = "Add Invigilator";
        }

        private void AddInvigilatorForm_Load(object sender, EventArgs e)
        {

        }

       private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(InvigilatorTextBox.Text))
                {
                    MessageBox.Show("Please enter the Invigilator Name.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(InvigilatorEmpIdTextBox.Text))
                {
                    MessageBox.Show("Please enter the Invigilator Emp Id.",
                       "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string name = InvigilatorTextBox.Text.Trim();
                bool isAvailable = IsAvailableCheckBox.Checked;
                string empId = InvigilatorEmpIdTextBox.Text.Trim();

                //call query function
                int result = invigilatorIntermediary.InsertInvigilator(name, isAvailable,empId);
                if (result > 0)
                {
                    MessageBox.Show("Invigilator Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error: " + invigilatorIntermediary.LastError,
                        "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearForm()
        {
            InvigilatorEmpIdTextBox.Clear();
            InvigilatorEmpIdTextBox.Clear();
            IsAvailableCheckBox.Checked = false;
        }
    }
}
