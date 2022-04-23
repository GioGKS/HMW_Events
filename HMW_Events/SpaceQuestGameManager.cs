using System;
namespace HMW_Events
{
    public class SpaceQuestGameManager
    {
        //Fields
        private int goodSpaceShipHitPoints { get; set; }
        private int shipXLocation { get; set; }
        private int shipYlocation { get; set; }
        private int numberOfBadShips { get; set; }
        private int currentLevel { get; set; }

        //Events
        public event EventHandler<PointseventArgs> GoodSpaceshipHPChanged;
        public event EventHandler<LocationeventArgs> GoodSpaceShipLocationchanged;
        public event EventHandler<PointseventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipExplodedeventArgs> BadShipsExploded;
        public event EventHandler<LeveleventArgs> LevelUpreached;

        //Ctors
        public SpaceQuestGameManager(int hitPoints, int xLoc, int yLoc, int numOfBadShips)
        {
            goodSpaceShipHitPoints = hitPoints;
            shipXLocation = xLoc;
            shipYlocation = yLoc;
            numberOfBadShips = numOfBadShips;
        }

        public void MoveSpaceShip(int newX, int newY)
        {
            shipXLocation = newX;
            shipYlocation = newY;
            ONGoodSpaceShipLocationChanged(newX, newY);
            Console.WriteLine($"New Locations are: XLocation - {shipXLocation}, YLocation - {shipYlocation}");

        }

        public void GoodSpaceShipGotDamaged(int damage)
        {
            goodSpaceShipHitPoints -= damage;
            ONGoodspaceShipGotDestroyed(goodSpaceShipHitPoints);
            Console.WriteLine($"Current Level After Damage: {goodSpaceShipHitPoints}");

        }

        public void GoodShipHitPoints(int hitPoints)
        {
            goodSpaceShipHitPoints = hitPoints;
            ONGoodShipHPChanged(hitPoints);
            Console.WriteLine($"Good Ship hit Points number: {goodSpaceShipHitPoints}");
        }

        public void GoodShipGotExtraHP(int hp)
        {
            goodSpaceShipHitPoints += hp;
            ONGoodShipHPChanged(hp);
            Console.WriteLine($"COOL! We Got Extra HP,Now We Have {goodSpaceShipHitPoints} HP!!");
        }

        public void EnemyshipsDestroyed(int numberOfbadshipsDestroyed)
        {
            numberOfBadShips -= numberOfbadshipsDestroyed;
            ONLevelUpReached();
            Console.WriteLine($"Number Of Bad ships Left: {numberOfBadShips} and Current Level Is: {currentLevel}");
        }


        //On Ctors
        private void ONGoodSpaceShipLocationChanged(int n1, int n2)
        {
            GoodSpaceShipLocationchanged?.Invoke(this, new LocationeventArgs(n1, n2));
        }

        private void ONGoodShipHPChanged(int hit)
        {
            GoodSpaceshipHPChanged?.Invoke(this, new PointseventArgs(hit));
        }

        private void ONGoodspaceShipGotDestroyed(int num)
        {
            if (goodSpaceShipHitPoints == 0 || goodSpaceShipHitPoints < 0)
            {
                GoodSpaceShipDestroyed?.Invoke(this, new PointseventArgs(num));
            }
        }

        private void ONBadShipsExploded(int badShipNum)
        {
            if(numberOfBadShips == 0 || numberOfBadShips < 0)
            {
                BadShipsExploded?.Invoke(this, new BadShipExplodedeventArgs(badShipNum));
            }
        }

        private void ONLevelUpReached()
        {
            if(numberOfBadShips == 0)
            {
                currentLevel++;
            }
        }

    }

    
}
