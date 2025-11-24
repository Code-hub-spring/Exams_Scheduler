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
        public ViewInvigilatorForm()
        {
            InitializeComponent();
        }

        public static ViewInvigilatorForm GetViewInvigilatorFormInstance()
        {
            //This method returns an instance of ViewInvigilatorForm, only if the instance is null.
            if (instance == null)
            {
                instance = new ViewInvigilatorForm();
            }
            return instance;
        }
        private void ViewInvigilatorForm_Load(object sender, EventArgs e)
        {
            try
            {
                InvigilatorIntermediary invigilatorIntermediary = new InvigilatorIntermediary();

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
    }
}

