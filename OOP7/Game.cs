using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
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
        void ProcessLobby()
        {
            Console.WriteLine("게임에 접속했습니다.");
            Console.WriteLine("캐릭터를 생성해 주세요");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]마법사");

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
        void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1]필드로 간다.");
            Console.WriteLine("[2]로비로 돌아간다.");
            Console.WriteLine("[3]플레이어 정보확인.");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    mode = GameMode.Field;
                    break;
                case 2:
                    mode = GameMode.Lobby;

                    break;
                case 3:
                    Console.WriteLine($"플레이어 직업 : {player.GetPlayerType()}");
                    Console.WriteLine($"플레이어의 체력 : {player.GetHP()}");
                    Console.WriteLine($"플레이어의 공격력 : {player.GetAttack()}");

                    break;

            }
        }
        void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다.");
            CreateRandomMonster();
            mode = GameMode.Fight;
        }
        void ProcessFight()
        {

        }
        void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);
            switch (randValue)
            {
                case (int)MonsterType.Slime:
                    monster = new Slime();
                    Console.WriteLine("슬라임등장!");
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크등장!");
                    monster = new Orc();
                    break;
                case (int)MonsterType.Skeleton:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤등장!");
                    break;
            }   

        }



    }
}
