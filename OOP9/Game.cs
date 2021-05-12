using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
{
    enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
        Fight
    }
    class Game
    {
        GameMode mode = GameMode.Lobby;
        Player player = null;
        Monster monster = null;
        Random rand = new Random();
        public void Process()
        {
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
                case GameMode.Fight:
                    ProcessFight();
                    break;
                
                    
            }

        }
        private void ProcessLobby() 
        {
            Console.WriteLine("게임에 접속했습니다.");
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown() {
            Console.WriteLine("마을에 입장했습니다!");
            Console.WriteLine("[1]필드로 나간다");
            Console.WriteLine("[2]로비로 돌아간다");
            Console.WriteLine("[3]플레이어 정보 확인");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    
                    mode = GameMode.Field;
                    break;
                case "2":
                    
                    mode = GameMode.Lobby;
                    break;
                case "3":
                    Console.WriteLine($"플레이어의 직  업 : {player.GetPlayerType()}");
                    Console.WriteLine($"플레이어의 체  력 : {player.GetHp()}");
                    Console.WriteLine($"플레이어의 공격력 : {player.GetAttack()}");
                    break;
            }
        }
        private void ProcessField() {
            Console.WriteLine("필드에 입장했습니다.");
            CreateRandomMonster();
            mode = GameMode.Fight;
        }
        private void ProcessFight() {
            Console.WriteLine("[1]싸운다");
            Console.WriteLine("[2]일정 확률로 도망친다");
            Console.WriteLine("[3]몬스터 정보 확인");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    Fight();
                    break;
                case "2":

                    TryEscape();
                    break;
                case "3":
                    Console.WriteLine($"몬스터의 정  보 : {monster.GetMonsterType()}");
                    Console.WriteLine($"몬스터의 체  력 : {monster.GetHp()}");
                    Console.WriteLine($"몬스터의 공격력 : {monster.GetAttack()}");
                    break;
            }
        }
        private void Fight() {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamage(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine("[1]마을로 간다");
                    Console.WriteLine("[2]필드에 머무른다");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            mode = GameMode.Town;
                            break;
                        case "2":
                            break;
                    }
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
        private void TryEscape() {
            int randValue = rand.Next(0, 101);
            if (randValue < 33)
            {
                Console.WriteLine("도망 성공!");
                mode = GameMode.Town;
            }
            else
            {
                Console.WriteLine("도망 실패!");
                Fight();
            }
        }
        private void CreateRandomMonster() {
            int randValue = rand.Next(1, 4);
            switch (randValue)
            {
                case (int)MonsterType.Slime :
                    monster = new Slime();
                   break;
                case (int)MonsterType.Orc:
                    monster = new Orc();
                    break;
                case (int)MonsterType.Skeleton:
                    monster = new Skeleton();
                    break;
            }
        }
    }
}
