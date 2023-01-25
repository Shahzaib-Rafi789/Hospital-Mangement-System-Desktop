using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Room
    {
        private string name;
        private string status;
        private string type;//surgery room or regular room

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }

        public Room(string name, string status, string type)
        {
            Name = name;
            Status = status;
            Type = type;
        }

        public bool IsRoomFree()
        {
            if(Status == "Occupied")
            {
                return false;
            }
            return true;
        }

        public void ChangeStatus()
        {
            if(Status == "Free")
            {
                Status = "Occupied";
            }
            else
            {
                Status = "Free";
            }
        }
        
    }
}
