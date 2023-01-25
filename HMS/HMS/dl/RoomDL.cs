using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
        class RoomDL
        {
            static public List<Room> Rooms = new List<Room>();

            static public void AddRoomIntoList(Room R)
            {
                Rooms.Add(R);
            }

            static public void LoadRoomData(string path)
            {
                string Record;
                StreamReader file = new StreamReader(path);

                if (File.Exists(path))
                {
                    while ((Record = file.ReadLine()) != null)
                    {
                        string[] SplittedRecords = Record.Split(',');
                        Room R = new Room(SplittedRecords[0], SplittedRecords[1], SplittedRecords[2]);
                        AddRoomIntoList(R);
                    }
                }

                file.Close();
            }

            static public Room GetRoomObj(string name)
            {
                foreach(Room i in Rooms)
                {
                    if(i.Name == name)
                    {
                        return i;
                    }
                }
                return null;
            }

            static public void UpdateRoomInFile(string path)
            {
                StreamWriter file = new StreamWriter(path, false);
                foreach(Room i in Rooms)
                {
                    file.WriteLine(i.Name + ',' + i.Status + ',' + i.Type);
                    file.Flush();
                }
                file.Close();
            }
        }
}
