using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    enum MonsterType
    {
        None,
        Zombie,
        Skeleton,
        Creeper
    }
    class Monster : Creature
    {
        protected MonsterType _type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            _type = type;
        }
        public MonsterType GetMonsterType(Monster monster) { return monster._type; }
    }
    class Zombie : Monster
    {
        public Zombie() : base(MonsterType.Zombie)
        {
            SetInfo(30, 10);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(20, 12);
        }
    }
    class Creeper : Monster
    {
        public Creeper() : base(MonsterType.Creeper)
        {
            SetInfo(15, 50);
        }
    }
}
