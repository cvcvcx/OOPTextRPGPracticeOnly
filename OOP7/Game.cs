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
        Player player = new Player();
        Monster monster = new Monster();
        Random rand = new Random();

        public void Process()
        {

            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    break;
                case GameMode.Field:
                    break;
                case GameMode.Fight:
                    break;
              
            }
        }
        void ProcessLobby()
        {
            Console.WriteLine("게임에 접속했습니다.");
            Console.WriteLine("캐릭터를 생성해 주세요");

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



    }
}
