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
        }
        private void ProcessTown()
        {

        }
        private void ProcessField()
        {

        }
    }
   
}
