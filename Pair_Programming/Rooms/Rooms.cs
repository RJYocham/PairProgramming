using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming.Rooms
{
    public class RoomOne : IRooms
    {
        public string RoomName => "Entrance";

        public string RoomDescription => "info about room here";
    }

    public class RoomTwo : IRooms
    {
        public string RoomName => "RoomTwo";

        public string RoomDescription => "info about room here";
    }

    public class RoomThree : IRooms
    {
        public string RoomName => "RoomThree";

        public string RoomDescription => "info about room here";
    }

    public class RoomFour : IRooms
    {
        public string RoomName => "RoomFour";

        public string RoomDescription => "info about room here";

    }

    public class RoomFive : IRooms
    {
        public string RoomName => "RoomFive";

        public string RoomDescription => "info about room here";
    }

}
