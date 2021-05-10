using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
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
        protected MonsterType _type = MonsterType.None;

        protected Monster(MonsterType type) : base(CreatureType.Monster){ _type = type; }

        public MonsterType GetMonsterType(Monster monster) { return _type; }
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
            SetInfo(50, 5);
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
