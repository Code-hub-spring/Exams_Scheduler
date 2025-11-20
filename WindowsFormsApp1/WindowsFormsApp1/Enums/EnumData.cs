using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Enums
{
   
        public enum EnumData
    {
        [Description("Computer & Information System")]
        ComputerAndInformationSystem = 0,

        [Description("Computer Science")]
        ComputerScience = 1,

        [Description("Data Science")]
        DataScience = 2,

        [Description("Industrial Production")]
        IndustrialProduction = 3,

        [Description("Management & Security System")]
        ManagementAndSecuritySystem = 4

    }

    
}
