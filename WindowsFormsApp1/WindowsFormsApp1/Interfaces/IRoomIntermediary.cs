using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    internal interface IRoomIntermediary
    {
        int AddRoom(int roomNumber, string roomName, int roomCapacity);
        DataTable ListRooms();
        //property
        string LastError { get; set; }
    }
}
