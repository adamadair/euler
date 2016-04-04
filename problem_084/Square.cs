using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public enum SquareType
    {
        Normal,
        Jail,
        CommunityChest,
        Chance,
        Railway,
        Utility,
        GoToJail
    }

    public class Square
    {
        public Square(string name, SquareType type, string id)
        {
            Name = name;
            Type = type;
            Id = id;
            Visits = 0;
        }
        public SquareType Type { get; set; }
        public string Name { get; set; }
        public int Visits { get; set; }
        public string Id { get; set; }
    }
}
