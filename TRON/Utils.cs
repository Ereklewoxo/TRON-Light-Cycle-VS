namespace TRON
{
    public class Utils
    {
        public static List<ConsoleKey> P1Keys()
        {
            List<ConsoleKey> p1keys = new()
            {
                ConsoleKey.RightArrow,
                ConsoleKey.UpArrow,
                ConsoleKey.LeftArrow,
                ConsoleKey.DownArrow,
            };
            return p1keys;
        }
        public static List<ConsoleKey> P2Keys()
        {
            List<ConsoleKey> p2keys = new()
            {
                ConsoleKey.D,
                ConsoleKey.W,
                ConsoleKey.A,
                ConsoleKey.S
            };
            return p2keys;
        }
    }
} 