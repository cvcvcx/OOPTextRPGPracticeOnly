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
        public void Process()
        {
            GameMode mode = GameMode.Lobby;
            Console.WriteLine("게임에 접속하였습니다.");
            Console.WriteLine("캐릭터를 생성해주세요.");
            
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:

                    break;
                case GameMode.Field:

                    break;
            }
        }
        private void ProcessLobby()
        {

        }
    }
}
