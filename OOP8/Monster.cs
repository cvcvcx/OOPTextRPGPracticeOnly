using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    enum MonsterType
    {
        None,
        Slime,
        Orc,
        Skeleton
    }
    class Monster : Creature
    {
        MonsterType _type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster) { _type = type; }
        //크리쳐타입이 플레이어인 크리쳐 생성과 동시에, 하위 클래스에서(Knight,Archer,Mage) 플레이어타입을 결정해서 플레이어를 생성.
        public MonsterType GetMonsterType() { return _type; }

    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(20, 2);
        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(40, 4);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(30, 3);
        }
    }
}
