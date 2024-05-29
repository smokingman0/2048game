using _2048Console.Managers;

namespace _2048Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            var gameManager = new GameManager();
            
            gameManager.ManageGame();
        }
    }
}