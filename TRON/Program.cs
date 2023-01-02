namespace TRON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set.SetMenu();
            do
            {
                Console.Write("\x1b[48;2;0;0;0m");
                Console.Clear();
                Console.WriteLine(Menu.Logo);
                Menu.MainMenu();
                Console.Clear();
                Set.SetGame();
                Game.GameLoop();
                Console.Clear();
                Set.SetMenuAfterGame();
                Console.Clear();
            } while (true);
        }
    }
} 