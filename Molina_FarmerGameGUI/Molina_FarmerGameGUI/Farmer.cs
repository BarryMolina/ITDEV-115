using System;
using System.Collections;

namespace Molina_FarmerGameGUI
{
    class Farmer
    {
        private const string nothing = "*move nothing*";
        private Direction farmer;
        private ArrayList northBank;
        private ArrayList southBank;

        public string Nothing
        {
            get { return nothing; }
        }
        public Direction TheFarmer
        {
            get { return farmer; }
        }
        public ArrayList NorthBank
        {
            get { return northBank; }

        }
        public ArrayList SouthBank
        {
            get { return southBank; }
        }

        public bool AnimalAteFood(String animal)
        {
            bool ateIt = false;
            if (animal == "FOX")
            {
                if (farmer == Direction.North)
                {
                    if (southBank.Contains("FOX") && southBank.Contains("CHICKEN"))
                    {
                        ateIt = true;
                    }
                }
                else
                {
                    if (northBank.Contains("FOX") && northBank.Contains("CHICKEN"))
                    {
                        ateIt = true;
                    }
                }
            }
            else
            {
                if (farmer == Direction.North)
                {
                    if (southBank.Contains("CHICKEN") && southBank.Contains("GRAIN"))
                    {
                        ateIt = true;
                    }
                }
                else
                {
                    if (northBank.Contains("CHICKEN") && northBank.Contains("GRAIN"))
                    {
                        ateIt = true;
                    }
                }
            }
            return ateIt;
        }

        public bool DetermineWin()
        {
            bool win = false;
            if (southBank.Count == 3)
            {
                win = true;
            }
            return win;
        }

        public Farmer()
        {
            farmer = Direction.North;

            northBank = new ArrayList() { "FOX", "CHICKEN", "GRAIN" };
            southBank = new ArrayList();
        }

        public void Move(String item)
        {
            if (farmer == Direction.North)
            {
                if (item != nothing)
                {
                    northBank.Remove(item);
                    southBank.Add(item);
                }
                farmer = Direction.South;
            }
            else
            {
                if (item != nothing)
                {
                    southBank.Remove(item);
                    northBank.Add(item);
                }
                farmer = Direction.North;
            }
        }
    }

    public enum Direction
    {
        North,
        South
    }
}
