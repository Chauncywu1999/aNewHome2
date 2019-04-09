using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHome
{
    class Outside:Location
    {
        private bool hot;

        public Outside (string name,bool hot):base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += "   It's very hot.";
                return newDescription;
            }
        }
    }

    class OutsideWithDoor:Outside,IHasExteriorDoor
    {
        public OutsideWithDoor(string name,bool hot,string doorDescription):base(name,hot)
        {
            this.DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " You see " + DoorDescription + ".";
            }
        }
    }

    class OutsideWithHidingPlace:Outside,IHidingPlace
    {
        public OutsideWithHidingPlace(string name,bool hot,string hidingPlaceName):base(name,hot)
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
