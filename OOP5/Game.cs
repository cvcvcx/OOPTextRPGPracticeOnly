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
                    break;
                case GameMode.Town:
                    break;
                case GameMode.Field:
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

                    break;
            }
        }

    }
}
