using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum PlayerType
    {
        None,
        Knight,
        Archer,
        Mage
    }
    class Player : Creature
    {
        protected PlayerType _type = PlayerType.None;
        //생성자인데, 인자를 플레이어 타입으로 받고, 기본적으로 크리쳐타입이 플레이어인 크리쳐를 만듬.
        protected Player(PlayerType type) : base(CreatureType.Player)
        { _type = type; }
    }
    //생성자에서 
     class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
            //나이트 생성자 = 인자는 받지 않고, 기본적으로 플레이어타입이 나이트인 플레이어를 만듬
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        //아쳐 생성자 = 인자는 받지 않고, 기본적으로 플레이어타입이 아쳐인 플레이어를 만듬
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        //나이트 생성자 = 인자는 받지 않고, 기본적으로 플레이어타입이 나이트인 플레이어를 만듬
        {
            SetInfo(50, 15);
        }
    }
}
