﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    enum PlayerType{
        None,
        Knight,
        Archer,
        Mage
    }
    class Player : Creature
    {
        protected PlayerType _type;
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            _type = type;
        }
    }
    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }
}
