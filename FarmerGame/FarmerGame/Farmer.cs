using System;
using System.Collections;
namespace FarmerGame
{
    public class Farmer
    {
        private Direction farmer;
        private ArrayList northBank;
        private ArrayList southBank;

        public Direction TheFarmer
        { 
            get { return farmer; }
        }
        public ArrayList NorthBank { get; }
        public ArrayList SouthBank { get; }


        public bool AnimalAteFood()
        {
            return true;
        }

        public bool DetermineWin()
        { 
            return true;
        }

        public Farmer()
        {
            farmer = Direction.North;

            northBank = new ArrayList() { "FOX", "CHICKEN", "GRAIN" };
            southBank = new ArrayList();
        }

        public void Move()
        { 
        }
    }

    public enum Direction
    { 
        North,
        South
    }
}
