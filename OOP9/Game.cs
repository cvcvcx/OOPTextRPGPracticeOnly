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
        private void ProcessLobby() { }
        private void ProcessTown() { }
        private void ProcessField() { }
        private void ProcessFight() { }
        private void Fight() { }
        private void TryEscape() { }
        private void CreateRandomMonster() { }
    }
}
