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



        }

        private void ProcessFight() { }

        private void CreateRandomMonster()
        {

        }
    }
}
