using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    internal interface IInvigilatorIntermediary
    {
        string LastError { get; set; }
        DataTable GetAllInvigilators();
        int InsertInvigilator(string name, bool available, string empId);

    }
}
