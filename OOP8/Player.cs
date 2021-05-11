using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    enum PlayerType
    {
        None,
        Knight,
        Archer,
        Mage
    }
    class Player: Creature
    {
        PlayerType _type = PlayerType.None;
        protected Player(PlayerType type) : base(CreatureType.Player) { _type = type; }
        //크리쳐타입이 플레이어인 크리쳐 생성과 동시에, 하위 클래스에서(Knight,Archer,Mage) 플레이어타입을 결정해서 플레이어를 생성.
        public PlayerType GetPlayerType() { return _type; }

    }
    class Knight : Player
    {
        public Knight(): base(PlayerType.Knight) 
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
