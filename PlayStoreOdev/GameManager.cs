using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStoreOdev
{
    class GameManager
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sisteme ***" + game.GameName + "*** oyunu eklendi\n");
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sistemden ***" + game.GameName + "*** oyunu silindi\n");
        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sistemde ***" + game.GameName + "*** oyunu güncellendi\n");
        }
    }
}
