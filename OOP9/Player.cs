using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
{
    enum PlayerType
    {
        None,
        Knight,
        Archer,
        Mage
    }
    class Player:Creature
    {
        PlayerType _playerType = PlayerType.None;
        protected Player(PlayerType type) : base(CreatureType.Player){ _playerType = type; }
        public PlayerType GetPlayerType() { return _playerType; }
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
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
