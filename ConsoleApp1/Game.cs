using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
        //선언할 때, 클래스변수로 선언하지 않으면 다른 함수에서 사용못함
        GameMode mode = GameMode.Lobby;
        Player player = null;
        public void Process()
        {
            
            //플레이어를 눌로 만들어 놓음
            
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

            Console.WriteLine("게임에 접속하였습니다.");
            Console.WriteLine("캐릭터를 생성해주세요.");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case (int)PlayerType.Knight:
                    player = new Knight();
                    Console.WriteLine($"HP = {player.GetHp()}");
                    Console.WriteLine($"Attack = {player.GetAttack()}");
                    mode = GameMode.Town;
                    
                    break;
                case (int)PlayerType.Archer:
                    player = new Archer();
                    Console.WriteLine($"HP = {player.GetHp()}");
                    Console.WriteLine($"Attack = {player.GetAttack()}");
                    mode = GameMode.Town;
                    break;
                case (int)PlayerType.Mage:
                    player = new Mage();
                    Console.WriteLine($"HP = {player.GetHp()}");
                    Console.WriteLine($"Attack = {player.GetAttack()}");
                    mode = GameMode.Town;
                    break;
            }

        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1]필드로 나간다");
            Console.WriteLine("[2]로비로 돌아간다");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    mode = GameMode.Field;
                    break;
                case 2:
                    mode = GameMode.Lobby;
                    break;
            }

        }
        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다");
        }
    }
}
