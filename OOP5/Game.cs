using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    class Game
    {
        Random rand = new Random();
        GameMode mode = GameMode.Lobby;
        Player player = null;
        Monster monster = null;

        public void Process()
        {
            Console.WriteLine("게임에 접속하셨습니다.");

            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }
        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]바바리안");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town; ;
                    break;
                case "3":
                    player = new Barbarian();
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다");
            Console.WriteLine($"플레이어의HP{player.GetHp()} 공격력 {player.GetAttack()}");

            Console.WriteLine("[1]필드로 나간다.");
            Console.WriteLine("[2]로비로 돌아간다.");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }

        }
        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다.");
            CreateRandomMonster();
            string input = "";
            SelectOption(ref input);
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
                case "3":
                    ProcessShowMonsterInfo(monster);
                    ProcessFight();
                    break;
            }


        }
        private string SelectOption(ref string input)
        {
            
            Console.WriteLine("[1]싸운다");
            Console.WriteLine("[2]일정확률로 마을로 돌아간다");
            Console.WriteLine("[3]몬스터 정보");

            while (input != "1" && input != "2" && input != "3")
            {
                input = Console.ReadLine();
                break;
            }
            return input;
            
        }

        private void ProcessFight() {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamage(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다");
                    mode = GameMode.Field;
                    break;
                }
                damage = monster.GetAttack();
                player.OnDamage(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("패배했습니다.");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }
        private void TryEscape() 
        {
            int randValue = rand.Next(0, 101);
                
           if(randValue<33){
                Console.WriteLine("도망성공!");
                mode = GameMode.Town;
            }
            else
            {
                Console.WriteLine("도망실패.."); 
                ProcessFight();
            }
        }
        private void ProcessShowMonsterInfo(Monster monster)
        {
            Console.WriteLine($"몬스터 종류{monster.GetMonsterType()}");
            Console.WriteLine($"몬스터 HP{monster.GetHp()}");
            Console.WriteLine($"몬스터 공격력{monster.GetAttack()}");
        }

        private void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);
            switch (randValue)
            {
                case (int)MonsterType.Zombie:
                    monster = new Zombie();
                    Console.WriteLine("좀비가 나타났습니다!");
                    break;
                case (int)MonsterType.Skeleton:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 나타났습니다!");
                    break;
                case (int)MonsterType.Creeper:
                    monster = new Creeper();
                    Console.WriteLine("크리퍼가 나타났습니다!");
                    break;
            }
        }
    }
}
