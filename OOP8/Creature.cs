using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    enum CreatureType
    {
        None,
        Player,
        Monster
    }
    class Creature
    {
        CreatureType _type = CreatureType.None;
        protected int _hp;
        protected int _attack;
        protected Creature(CreatureType type) { _type = type; }

        public int GetHp() { return _hp; }
        public int GetAttack() { return _attack; }
        public void SetInfo(int hp,int attack) { _hp = hp;_attack = attack; }
        public bool IsDead() { return _hp <= 0; }
        public void OnDamage(int damage) { _hp -= damage; }

    }
}
