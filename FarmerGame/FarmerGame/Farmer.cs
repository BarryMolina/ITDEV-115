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

        public bool Move(String item)
        {
            bool validMove = false;

            if (farmer == Direction.North)
            {
                if (String.IsNullOrEmpty(item))
                    validMove = true;

                else if (northBank.Contains(item))
                {
                    northBank.Remove(item);
                    southBank.Add(item);
                    validMove = true;
                }
                if (validMove)
                {
                    farmer = Direction.South;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(item))
                {
                    validMove = true;
                }
                else if (southBank.Contains(item))
                {
                    southBank.Remove(item);
                    northBank.Add(item);
                    farmer = Direction.North;
                    validMove = true;
                }
                if (validMove)
                {
                    farmer = Direction.North;
                }
            }
            return validMove;
        }
    }

    public enum Direction
    { 
        North,
        South
    }
}
