using System;
namespace HMW_Events
{
    public class PointseventArgs : EventArgs
    {
        public int HitPoints { get; set; }

        public PointseventArgs(int num)
        {
            HitPoints += num;
        }
    }

    public class LocationeventArgs : EventArgs
    {
        public int currentXLocation { get; set; }
        public int currentYLocation { get; set; }

        public LocationeventArgs(int n1,int n2)
        {
            currentXLocation = n1;
            currentYLocation = n2;
        }

    }

    public class BadShipExplodedeventArgs : EventArgs
    {
        public int NumberOfDestroyedBadShips { get; set; }

        public BadShipExplodedeventArgs(int badShipNum)
        {
            NumberOfDestroyedBadShips = badShipNum;
        }
    }

    public class LeveleventArgs : EventArgs
    {
        public int CurrentLevel { get; set; }
    }
}
