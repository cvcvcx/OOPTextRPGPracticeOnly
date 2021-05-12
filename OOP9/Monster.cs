using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
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
        MonsterType _monsterType = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster) { _monsterType = type; }
        public MonsterType GetMonsterType() { return _monsterType; }

    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(15, 2);

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
