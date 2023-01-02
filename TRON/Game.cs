using System.Text;

namespace TRON
{
    public class Game
    {
        public static void GameLoop()
        {
            ConsoleKeyInfo key;
            int P1Score = 0;
            int P2Score = 0;
            do
            {
                Console.Write("\x1b[48;2;0;0;0m");
                var P1Head = new List<int> { 15, 22 };
                var P2Head = new List<int> { 15, 1 };
                var P1TailX = new List<int> { };
                var P1TailY = new List<int> { };
                var P2TailX = new List<int> { };
                var P2TailY = new List<int> { };
                int P1Direction = 0;
                int P2Direction = 2;
                bool P1Crashed = false;
                bool P2Crashed = false;
                int speed = 46;
                do
                {
                    if (Console.CursorVisible == true)
                        Set.SetMenu();
                    //draw hud
                    Console.WriteLine($"{Graphics.Colors()[0]} P1 {Graphics.HealthBarP1()[P1Score]}{Graphics.Colors()[1]}                                    P2 {Graphics.HealthBarP2()[P2Score]} ");
                    //read the input
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                        if (Utils.P1Keys().Contains(key.Key))
                        {
                            if (key.Key == ConsoleKey.RightArrow && P1Direction != 3)
                                P1Direction = 1;
                            else if (key.Key == ConsoleKey.UpArrow && P1Direction != 2)
                                P1Direction = 0;
                            else if (key.Key == ConsoleKey.DownArrow && P1Direction != 0)
                                P1Direction = 2;
                            else if (key.Key == ConsoleKey.LeftArrow && P1Direction != 1)
                                P1Direction = 3;
                        }
                        else if (Utils.P2Keys().Contains(key.Key))
                        {
                            if (key.Key == ConsoleKey.D && P2Direction != 3)
                                P2Direction = 1;
                            else if (key.Key == ConsoleKey.W && P2Direction != 2)
                                P2Direction = 0;
                            else if (key.Key == ConsoleKey.S && P2Direction != 0)
                                P2Direction = 2;
                            else if (key.Key == ConsoleKey.A && P2Direction != 1)
                                P2Direction = 3;
                        }
                    }
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                        if (Utils.P1Keys().Contains(key.Key))
                        {
                            if (key.Key == ConsoleKey.RightArrow && P1Direction != 3)
                                P1Direction = 1;
                            else if (key.Key == ConsoleKey.UpArrow && P1Direction != 2)
                                P1Direction = 0;
                            else if (key.Key == ConsoleKey.DownArrow && P1Direction != 0)
                                P1Direction = 2;
                            else if (key.Key == ConsoleKey.LeftArrow && P1Direction != 1)
                                P1Direction = 3;
                        }
                        else if (Utils.P2Keys().Contains(key.Key))
                        {
                            if (key.Key == ConsoleKey.D && P2Direction != 3)
                                P2Direction = 1;
                            else if (key.Key == ConsoleKey.W && P2Direction != 2)
                                P2Direction = 0;
                            else if (key.Key == ConsoleKey.S && P2Direction != 0)
                                P2Direction = 2;
                            else if (key.Key == ConsoleKey.A && P2Direction != 1)
                                P2Direction = 3;
                        }
                    }
                    //change the direction
                    switch (P1Direction)
                    {
                        case 0:
                            P1Head[1]--;
                            break;
                        case 1:
                            P1Head[0]++;
                            break;
                        case 2:
                            P1Head[1]++;
                            break;
                        case 3:
                            P1Head[0]--;
                            break;
                    }
                    switch (P2Direction)
                    {
                        case 0:
                            P2Head[1]--;
                            break;
                        case 1:
                            P2Head[0]++;
                            break;
                        case 2:
                            P2Head[1]++;
                            break;
                        case 3:
                            P2Head[0]--;
                            break;
                    }
                    //check game over
                    for (int i = 0; i < P1TailX.Count; i++)
                    {
                        if ((P1TailX[i] == P1Head[0] && P1TailY[i] == P1Head[1]) || (P2TailX[i] == P1Head[0] && P2TailY[i] == P1Head[1]) || P1Head[0] < 0 || P1Head[0] > Console.WindowWidth / 2 - 1 || P1Head[1] < 0 || P1Head[1] > Console.WindowHeight - 2)
                            P1Crashed = true;
                        if ((P1TailX[i] == P2Head[0] && P1TailY[i] == P2Head[1]) || (P2TailX[i] == P2Head[0] && P2TailY[i] == P2Head[1]) || P2Head[0] < 0 || P2Head[0] > Console.WindowWidth / 2 - 1 || P2Head[1] < 0 || P2Head[1] > Console.WindowHeight - 2)
                            P2Crashed = true;
                    }
                    //build game screen
                    StringBuilder gameScreen = new();
                    for (int y = 0; y < Console.WindowHeight - 1; y++)
                    {
                        for (int x = 0; x < Console.WindowWidth / 2; x++)
                        {
                            string artSymbol;
                            if (P1Head[0] == x && P1Head[1] == y)
                                artSymbol = Graphics.Colors()[0] + Graphics.Textures()[0].Item1;
                            else if (P2Head[0] == x && P2Head[1] == y)
                                artSymbol = Graphics.Colors()[1] + Graphics.Textures()[0].Item1;
                            else
                                artSymbol = Graphics.Colors()[2] + Graphics.Textures()[0].Item3;
                            for (int i = 0; i < P1TailX.Count; i++)
                            {
                                if ((P1TailX[i] == x && P1TailY[i] == y) && P1Crashed == false)
                                    artSymbol = Graphics.Colors()[0] + Graphics.Textures()[0].Item2;
                            }
                            for (int i = 0; i < P2TailX.Count; i++)
                            {
                                if ((P2TailX[i] == x && P2TailY[i] == y) && P2Crashed == false)
                                    artSymbol = Graphics.Colors()[1] + Graphics.Textures()[0].Item2;
                            }
                            gameScreen.Append(artSymbol);
                        }
                        if (y < Console.WindowHeight - 2)
                            gameScreen.AppendLine();
                    }
                    //update the tail
                    P1TailX.Add(P1Head[0]);
                    P1TailY.Add(P1Head[1]);
                    P2TailX.Add(P2Head[0]);
                    P2TailY.Add(P2Head[1]);
                    //update game screen
                    Console.Write(gameScreen);
                    Console.SetCursorPosition(0, Console.CursorTop - (Console.WindowHeight - 1));
                    if (P1Crashed || P2Crashed)
                        break;
                    Task.Delay(speed).Wait();
                } while (true);
                if (P1Crashed)
                    P2Score++;
                else if (P2Crashed)
                    P1Score++;
                Console.SetCursorPosition(0, Console.CursorTop - -7);
                if (P1Score == 5 || P2Score == 5)
                {
                    if (P1Score == 5)
                    {
                        Console.WriteLine("\x1b[48;2;18;255;205m\x1b[38;2;10;0;2m\n" +
                            "                                                              \n" +
                            "                           P1 WINS                            \n" +
                            "                                                              ");
                    }
                    if (P2Score == 5)
                    {
                        Console.WriteLine("\x1b[48;2;255;180;10m\x1b[38;2;0;2;10m\n" +
                            "                                                              \n" +
                            "                           P2 WINS                            \n" +
                            "                                                              ");
                    }
                    Console.WriteLine("" +
                        "             ──────────────┤ENTER├───────────────             \n" +
                        "                                                              ");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                    break;
                }
                if (P1Crashed && P2Crashed)
                {
                    Console.WriteLine("\x1b[48;2;30;200;40m\x1b[38;2;236;236;255m\n" +
                        "                                                              \n" +
                        "                         DOUBLE CRASH                         \n" +
                        "                                                              ");
                }
                else if (P1Crashed)
                {
                    Console.WriteLine("\x1b[48;2;255;180;10m\x1b[38;2;0;2;10m\n" +
                        "                                                              \n" +
                        "                          P2 SCORE++                          \n" +
                        "                                                              ");
                }
                else if (P2Crashed)
                {
                    Console.WriteLine("\x1b[48;2;18;255;205m\x1b[38;2;10;0;2m\n" +
                        "                                                              \n" +
                        "                          P1 SCORE++                          \n" +
                        "                                                              ");
                }
                Console.WriteLine("" +
                    "             ──────────────┤ENTER├───────────────             \n" +
                    "                                                              ");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Graphics.Countdown();
                Console.Write("\x1b[48;2;0;0;0m");
                Console.Clear();
            } while (true);
        }
    }
}