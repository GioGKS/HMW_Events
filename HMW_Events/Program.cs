using System;
using System.Threading;

namespace HMW_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceQuestGameManager SpaceGame = new SpaceQuestGameManager(100, 15, 20, 10);
            Gameviewer gameviewer = new Gameviewer();

            SpaceGame.GoodSpaceShipLocationchanged += gameviewer.GoodSpaceShipLocationChangedEventHandler;
            SpaceGame.LevelUpreached += gameviewer.LevelUpReachedEventHandler;
            SpaceGame.GoodSpaceshipHPChanged += gameviewer.GoodSpaceShipHPChangedEventHandler;


            SpaceGame.GoodSpaceShipGotDamaged(20);
            Thread.Sleep(1000);
            Console.WriteLine();

            SpaceGame.MoveSpaceShip(50, 70);
            Thread.Sleep(1000);
            Console.WriteLine();

            SpaceGame.GoodShipGotExtraHP(15);
            Thread.Sleep(1000);
        }
    }
}
