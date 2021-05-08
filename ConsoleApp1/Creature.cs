using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Creature
    {
        protected int _hp = 0;
        protected int _attack = 0;
        
        public int GetHp() { return _hp; }
        public int GetAttack() { return _attack; }

        public void SetInfo(int hp, int attack)
        {
            _hp = hp;
            _attack = attack;
        }

        public bool IsDead() { return _hp <= 0; }
        public void OnDamege(int damage) 
        {
            _hp -= damage;
            if (_hp < 0)
                _hp = 0;
        }
    }
}
