using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    internal interface ICourseIntermediary
    {
        string LastError { get; set; }
        DataTable ListCourses();
        
    }
}
