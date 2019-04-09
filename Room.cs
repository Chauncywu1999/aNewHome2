using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHome
{
    class Room:Location
    {
        private string decoration;

        public Room(string name,string decoration):base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get { return base.Description + " You see " + decoration + "."; }
        }
    }

    class RoomWithDoor:RoomWithHidingPlace,IHasExteriorDoor
    {
        public RoomWithDoor(string name,string decoration, string hidingPlaceName , string doorDescription):base(name,decoration,hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get;private set; }

        public Location DoorLocation { get; set; }
    }

    class RoomWithHidingPlace:Room,IHidingPlace
    {
        public RoomWithHidingPlace(string name,string decoration,string hidingPlaceName):base(name,decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + HidingPlaceName + ".";
            }
        }
    }
}
