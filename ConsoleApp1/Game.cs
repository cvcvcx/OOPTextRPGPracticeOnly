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
        Random rand = new Random();
        //선언할 때, 클래스변수로 선언하지 않으면 다른 함수에서 사용못함
        GameMode mode = GameMode.Lobby;
        Player player = null;
        Monster monster = null;
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
            CreateRandomMonster();
            Console.WriteLine("[1]싸운다");
            Console.WriteLine("[2]일정 확률로 도망친다");
            string input = Console.ReadLine();
            if (input == "1" || input == "2")
            {
                switch (input)
                {
                    case "1":
                        ProcessFight();
                        break;
                    case "2":
                        int randValue = rand.Next(0, 101);
                        if (randValue < 33)
                        {
                            Console.WriteLine("도망에 성공했습니다!");
                            mode = GameMode.Town;
                        }
                        else
                        {
                            Console.WriteLine("실패! 전투 시작!");
                            ProcessFight();
                        }
                        break;

                }
                
            }
            else
            {
                Console.WriteLine("정확한 수를 입력해주세요");
            }
           
        }
        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamege(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다");
                    Console.WriteLine($"남은 HP{player.GetHp()}");
                    mode = GameMode.Field;
                    return;
                }
                damage = monster.GetAttack();
                player.OnDamege(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("패배했습니다.");
                    mode = GameMode.Lobby;
                    return;
                }
            }
            
        }
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);
            switch (randValue)
            {
                case (int)MonsterType.Slime:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 소환되었습니다!");
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 소환되었습니다!");
                    monster = new Orc();
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 소환되었습니다!");
                    monster = new Skeleton();
                    break;
            }
        }
    }
}
