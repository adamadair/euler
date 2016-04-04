using System;

namespace Monopoly
{
    public class Monopoly
    {
        
        public Monopoly()
        {
        }


    }

    public enum SquareType
    {
        Normal,
        Jail,
        CommunityChest,
        Chance,
        Railway,
        GoToJail
    }

    public class Square
    {
        public Square(string name, SquareType type, int visits)
        {
            Name = name;
            Type = type;
            Visits = visits;
        }
        public SquareType Type { get; set; }
        public string Name { get; set; }
        public int Visits { get; set; }
    }


}

