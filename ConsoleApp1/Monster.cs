using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            _type = type;
        }
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
