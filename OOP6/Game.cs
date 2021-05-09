using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }

    class Game
    {
        Player player = null;
        Monster monster = null;
        protected GameMode mode = GameMode.Lobby;
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
            }
        }
        private void ProcessLobby()
        {
            Console.WriteLine("게임에 접속하였습니다.");
            
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
            
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다");
        
        }
        private void ProcessField()
        {

            Console.WriteLine("필드에 입장했습니다.");
        }
    }
   
}
