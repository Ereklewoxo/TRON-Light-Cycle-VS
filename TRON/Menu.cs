namespace TRON
{
    public class Menu
    {
        public static string P1 = Graphics.Colors()[0];
        public static string P2 = Graphics.Colors()[1];
        public static string B = Graphics.Colors()[2];
        public static string G = Graphics.Colors()[3];
        public static string O = Graphics.Colors()[6];
        public static string T = Graphics.Colors()[5];
        public static string H = Graphics.Colors()[4];
        public static string R = Graphics.Colors()[7];
        public static string Logo = "" +
            $"{R}┌───────────────────────────────────┐\n" +
            $"{R}│{B}┼─┼─┼─┼─┼─┼─┼─┼─┼─┼─{G}│{B}─┼─┼─┼─┼─┼─┼─┼{R}│\n" +
            $"{R}│{B}┼─┼─┼ {O}══╦══ ════╗ ╔═══╗ ╓╖  ╥{B} ┼─┼─┼{R}│\n" +
            $"{R}│{G}────────{T}║{G}───{T}╔═══╗{G}─{T}║{G}─┼─{T}║{G}─{T}║╙ ╖║{G}──────{R}│\n" +
            $"{R}│{B}┼─┼─┼─┼ {H}╨   ╨   ╨ ╚═══╝ ╨  ╙╜{B}─┼─┼─┼{R}│\n" +
            $"{R}│{B}┼─┼─┼─┤{H}LIGHT CYCLE V{G}│{H}S{B}├─┼─┼─┼─┼─┼─┼{R}│\n" +
            $"{R}└───────────────────────────────────┘\n";
        public static void MainMenu()
        {
            ConsoleKeyInfo key;
            bool P1Ready = false;
            bool P2Ready = false;
            bool ready = false;
            Console.WriteLine("" +
                $"{H} P1 - {P1}▒▒▒▒▒▒▒██       {P2}██▒▒▒▒▒▒▒{H} - P2 \n\n" +
                $"{P1}      ▲ ◄ ▼ ► 0       {P2}V W A S D\n{B}" +
                "            └───┬───────┘\n" +
                "  ┌─────────────┘\n" +
                "  PRESS ANY OF THESE KEYS TO START");
            while (ready == false)
            {
                if (P1Ready == false && P2Ready == false)
                {
                    Console.WriteLine($"{B}" +
                        " ┌───────────┐         ┌───────────┐\n" +
                        " │ R E A D Y │         │ R E A D Y │\n" +
                        " └───────────┘         └───────────┘");
                }
                else if (P1Ready)
                {
                    Console.WriteLine($"{P1}" +
                        " ┌───────────┐\n" +
                        " │ R E A D Y │\n" +
                        " └───────────┘");
                }
                else if (P2Ready)
                {
                    Console.WriteLine($"{B}" +
                        $" ┌───────────┐         {P2}┌───────────┐{B}\n" +
                        $" │ R E A D Y │         {P2}│ R E A D Y │{B}\n" +
                        $" └───────────┘         {P2}└───────────┘");
                }
                Console.SetCursorPosition(0, Console.CursorTop - 3);
                key = Console.ReadKey(true);
                if (Utils.P1Keys().Contains(key.Key))
                    P1Ready = true;
                if (Utils.P2Keys().Contains(key.Key))
                    P2Ready = true;
                if (P1Ready == true && P2Ready == true)
                    ready = true;
            }
            Console.WriteLine($"{P1}" +
                        $" ┌───────────┐         {P2}┌───────────┐{P1}\n" +
                        $" │ R E A D Y │         {P2}│ R E A D Y │{P1}\n" +
                        $" └───────────┘         {P2}└───────────┘{H}");
            Console.SetCursorPosition(0, Console.CursorTop - -1);
            Console.WriteLine(" ────────────────┤3├──────────────── ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(" ────────────────┤2├──────────────── ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(" ────────────────┤1├──────────────── ");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(" ────────────────┤0├──────────────── ");
        }
    }
} 