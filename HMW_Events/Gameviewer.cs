using System;
namespace HMW_Events
{
    public class Gameviewer
    {
        public void GoodSpaceShipHPChangedEventHandler(object sender, PointseventArgs args)
        {
            Console.WriteLine($"HP Changed: {args.HitPoints}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationeventArgs locationevent)
        {
            Console.WriteLine($"Location Changed To: X: {locationevent.currentXLocation}, Y: {locationevent.currentYLocation}");
        }

        public void GoodSpaceShipDestroyedEventHandler(object sender, LocationeventArgs locationevent)
        {
            
        }

        public void BadShipExplodedEventHandler(object sender, BadShipExplodedeventArgs explodedeventArgs)
        {
            Console.WriteLine($"Number Of Exploded Bad Ships: {explodedeventArgs.NumberOfDestroyedBadShips}");
        }

        public void LevelUpReachedEventHandler(object sender, LeveleventArgs levelevent)
        {
            Console.WriteLine($"Level Up Reached To Level: {levelevent.CurrentLevel}");
        }
    }
}
