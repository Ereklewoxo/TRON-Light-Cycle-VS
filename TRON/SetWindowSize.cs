namespace TRON
{
    public class Set
    {
        public static void SetMenu()
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 37;
            Console.CursorVisible = false;
        }
        public static void SetGame()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.WindowWidth = 37 + i;
                Task.Delay(5).Wait();
            }
        }
        public static void SetMenuAfterGame()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.WindowWidth = 62 - i;
                Task.Delay(5).Wait();
            }
        }
    }
}