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
        internal static AddInvigilatorForm addInvigilatorInstance;
        InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();
        public AddInvigilatorForm()
        {
            InitializeComponent();
            Text = "Add Invigilator";
        }
         internal static AddInvigilatorForm GetAddInvigilatorFormInstance()
        {
            //This method returns an instance of AddInvigilatorForm, only if the instance is null.
            if (addInvigilatorInstance == null || addInvigilatorInstance.IsDisposed)
            {
                addInvigilatorInstance = new AddInvigilatorForm();
            }
            return addInvigilatorInstance;
        }

        private void AddInvigilatorForm_Load(object sender, EventArgs e)
        {

        }

        private void AddInvigilatorForm_Close(object sender, EventArgs e)
        {
            addInvigilatorInstance = null;
        }
       private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(InvigilatorTextBox.Text!="")
                {
                    if(InvigilatorEmpIdTextBox.Text!="")
                    {
                        if (IsAvailableCheckBox.Checked)
                        {
                            string name = InvigilatorTextBox.Text.Trim();
                            bool isAvailable = IsAvailableCheckBox.Checked;
                            string empId = InvigilatorEmpIdTextBox.Text.Trim();
                            int result = invigilatorIntermediary.InsertInvigilator(name, isAvailable, empId);
                            if (result > 0)
                            {
                                MessageBox.Show("Invigilator Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResultLabel.Text = "Invigilator Added successfully.";
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("Error: " + invigilatorIntermediary.LastError,
                                    "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invigilator must be marked as available.",
                           "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the Invigilator Emp Id.",
                       "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Invigilator Name.",
                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
