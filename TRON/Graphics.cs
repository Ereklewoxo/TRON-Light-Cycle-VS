namespace TRON
{
    public class Graphics
    {
        public static List<Tuple<string, string, string>> Textures()
        {
            var textureTuples = new List<Tuple<string, string, string>>();
            textureTuples.Add(new Tuple<string, string, string>("██", "▒▒", "┼─"));
            return textureTuples;
        }
        public static List<string> Colors()
        {
            var colors = new List<string>();
            colors.Add("\x1b[38;2;125;253;254m");
            colors.Add("\x1b[38;2;255;180;10m");
            colors.Add("\x1b[38;2;10;18;38m");
            colors.Add("\x1b[38;2;50;255;70m");
            colors.Add("\x1b[38;2;236;236;255m");
            colors.Add("\x1b[38;2;100;160;250m");
            colors.Add("\x1b[38;2;10;20;200m");
            colors.Add("\x1b[38;2;240;10;10m");
            return colors;
        }
        public static List<string> HealthBarP1()
        {
            var healthBar = new List<string>();
            healthBar.Add($"{Colors()[2]}♦ ♦ ♦ ♦ ♦");
            healthBar.Add($"{Colors()[0]}♦ {Colors()[2]}♦ ♦ ♦ ♦");
            healthBar.Add($"{Colors()[0]}♦ ♦ {Colors()[2]}♦ ♦ ♦");
            healthBar.Add($"{Colors()[0]}♦ ♦ ♦ {Colors()[2]}♦ ♦");
            healthBar.Add($"{Colors()[0]}♦ ♦ ♦ ♦ {Colors()[2]}♦");
            healthBar.Add($"{Colors()[0]}♦ ♦ ♦ ♦ ♦");
            return healthBar;
        }
        public static List<string> HealthBarP2()
        {
            var healthBar = new List<string>();
            healthBar.Add($"{Colors()[2]}♦ ♦ ♦ ♦ ♦");
            healthBar.Add($"{Colors()[1]}♦ {Colors()[2]}♦ ♦ ♦ ♦");
            healthBar.Add($"{Colors()[1]}♦ ♦ {Colors()[2]}♦ ♦ ♦");
            healthBar.Add($"{Colors()[1]}♦ ♦ ♦ {Colors()[2]}♦ ♦");
            healthBar.Add($"{Colors()[1]}♦ ♦ ♦ ♦ {Colors()[2]}♦");
            healthBar.Add($"{Colors()[1]}♦ ♦ ♦ ♦ ♦");
            return healthBar;
        }
        public static void Countdown()
        {
            Console.WriteLine("             ────────────────┤03├────────────────             \n" +
                        "                                                              ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.WriteLine("             ────────────────┤02├────────────────             \n" +
                        "                                                              ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.WriteLine("             ────────────────┤01├────────────────             \n" +
                        "                                                              ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.WriteLine("             ────────────────┤00├────────────────             \n" +
                        "                                                              ");
        }
    }
}