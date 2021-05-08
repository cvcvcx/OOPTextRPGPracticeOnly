using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    enum PlayerType
    {
        None,
        Knight,
        Archer,
        Barbarian
    }
    class Player : Creature
    {
        protected PlayerType _type = PlayerType.None;
        protected Player(PlayerType type) : base(CreatureType.Player) { _type = type; }
    }
    class Knight : Player
    {
        
        public Knight() : base(PlayerType.Knight) 
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {

        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Barbarian : Player
    {

        public Barbarian() : base(PlayerType.Barbarian)
        {
            SetInfo(200, 15);
        }
    }
}
