using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    enum MonsterType 
    {
        None,
        Slime,
        Orc,
        Skeleton
    }
    class Monster:Creature
    {
        MonsterType _type = MonsterType.None;
        protected Monster(MonsterType type ) :base(CreatureType.Monster){ _type = type; }
    }
    class Slime:Monster
    {
        
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(20, 2);
        }
            
        }
    }
}
