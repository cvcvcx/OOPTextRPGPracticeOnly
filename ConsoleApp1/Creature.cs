using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum CreatureType
    {
        None,
        Player,
        Monster
    }
    class Creature
    {
        //인자가 들어간 빈 생성자를 생성함으로써 아무인자도 없는 생성자를 만들지 못하게 만듬
        protected Creature(CreatureType type) { }
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
