using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Models
{
    public class MeetingRoom
    {
        public Boolean add { get; set; }
        public static Array RoomList()
        {
            return new[] {
                new { text = "Meeting Room 1", id = 1, color = "#fcb65e" },
                new { text = "Meeting Room 2", id = 2, color = "#e18e92" },
                new { text = "Meeting Room 3", id = 3, color = "#e18e92" }
            };
        }
        public static Boolean AllowAdd()
        {
            if (2 > 10)
                return true;
            return false;
        }
        public static Boolean AllowDelete()
        {
            return true;
        }
        public static Boolean AllowUpdate()
        {
            return true;
        }
    }
}
