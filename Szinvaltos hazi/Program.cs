using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Szinvaltos_hazi
{
    class Program
    {

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Thread.Sleep(1000);
            #region töltés
            for (int toltes = 0; toltes < 3; toltes++)
            {
                Console.Write("Betöltés   ");
                Console.SetCursorPosition(8, 0);
                Thread.Sleep(500);
                Console.SetCursorPosition(0, 0);
                Console.Write("Betöltés.");
                Thread.Sleep(500);
                Console.SetCursorPosition(0, 0);
                Console.Write("Betöltés..");
                Thread.Sleep(500);
                Console.SetCursorPosition(0, 0);
                Console.Write("Betöltés...");
                Thread.Sleep(500);
                Console.SetCursorPosition(0, 0);

            }
            #endregion



            ///////////////////////////////////////////////////////////////////////////////////

            for (int start = 0; start < 20; start++)
            {
                Console.Clear();
                Console.SetWindowSize(80, 20);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                #region konzolkialakítás
                for (int i = 0; i < 20; i++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                //
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                          Takács Mátyás játékkonzol                         ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                Ver. 1.0  2019                              ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  "); Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("         Kérlek válasz egy játékot a megfelelő szám megnyomásával!          ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("         1. Szó party                                                       ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("         2. Rajz robot                                                      ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("         3. Kígyózó                                                         ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("         KILÉPÉS: ESC                                                       ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                            ");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.WriteLine();

                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(11, 6);
                #endregion

                while (true)
                {
                    ConsoleKeyInfo result = Console.ReadKey();
                    if (result.KeyChar == '1')
                    {
                        Thread.Sleep(500);
                        Console.SetCursorPosition(11, 7);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1. Szó party betöltése...");
                        Thread.Sleep(2000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();

                        #region 1. játék
                        Console.SetCursorPosition(2,8);
                        Console.WriteLine("Üdv! Kérlek adj meg egy négybetűs szót, csak az angol ABC kisbetűivel! (a-z)");
                        Console.WriteLine();
                        Console.Write("                             ");
                        string word = Console.ReadLine();
                        if (word.Length == 4)
                        {
                            char a1 = word[0];
                            char a2 = word[1];
                            char a3 = word[2];
                            char a4 = word[3];
                            Thread.Sleep(1500);
                            Console.Clear();
                            Console.SetCursorPosition(25, 8);
                            Console.WriteLine("Most pedig kezdődjön a rave party!!!");
                            Thread.Sleep(3000);
                            Console.Clear();

                            Console.SetWindowSize(70, 16);

                            for (int k = 0; k < 50; k++)
                            {
                                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                                Console.BackgroundColor = (ConsoleColor)rnd.Next(1, 16);
                                if (a4 == 'a')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine();

                                }
                                else if (a4 == 'b')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine();
                                }
                                else if (a4 == 'c')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████  ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 'd')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ████████   ");
                                }
                                else if (a4 == 'e')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███████████");
                                }
                                else if (a4 == 'f')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                }
                                else if (a4 == 'g')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███   █████");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 'h')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                }
                                else if (a4 == 'i')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                            █████████ ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                            █████████ ");
                                }
                                else if (a4 == 'j')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                                   ███");
                                    Console.WriteLine("                                                                   ███");
                                    Console.WriteLine("                                                                   ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 'k')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███  ███   ");
                                    Console.WriteLine("                                                           ██████     ");
                                    Console.WriteLine("                                                           ███  ███   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                }
                                else if (a4 == 'l')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███████████");
                                }
                                else if (a4 == 'm')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ██       ██");
                                    Console.WriteLine("                                                           ████   ████");
                                    Console.WriteLine("                                                           ██  ███  ██");
                                    Console.WriteLine("                                                           ██       ██");
                                    Console.WriteLine("                                                           ██       ██");
                                    Console.WriteLine("                                                           ██       ██");
                                }
                                else if (a4 == 'n')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ██████  ███");
                                    Console.WriteLine("                                                           ███  ██████");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                }
                                else if (a4 == 'o')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 'p')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███        ");
                                }
                                else if (a4 == 'q')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███    ███ ");
                                    Console.WriteLine("                                                           ███    ███ ");
                                    Console.WriteLine("                                                           ███    ███ ");
                                    Console.WriteLine("                                                           ███    ███ ");
                                    Console.WriteLine("                                                              ████████");
                                }
                                else if (a4 == 'r')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ████████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                }
                                else if (a4 == 's')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              ███     ");
                                    Console.WriteLine("                                                                ███   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 't')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                }
                                else if (a4 == 'u')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███████████");
                                }
                                else if (a4 == 'v')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                }
                                else if (a4 == 'w')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ██      ██");
                                    Console.WriteLine("                                                           ██      ██");
                                    Console.WriteLine("                                                           ██      ██");
                                    Console.WriteLine("                                                           ██  ██  ██");
                                    Console.WriteLine("                                                           ██  ██  ██");
                                    Console.WriteLine("                                                             ██  ██  ");
                                }
                                else if (a4 == 'x')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                              █████   ");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                    Console.WriteLine("                                                           ███     ███");
                                }
                                else if (a4 == 'y')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ██       ██");
                                    Console.WriteLine("                                                           ██       ██");
                                    Console.WriteLine("                                                             ██   ██  ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                    Console.WriteLine("                                                               ███    ");
                                }
                                else if (a4 == 'z')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                           ███████████");
                                    Console.WriteLine("                                                                   ███");
                                    Console.WriteLine("                                                                 ███  ");
                                    Console.WriteLine("                                                              ███     ");
                                    Console.WriteLine("                                                           ███        ");
                                    Console.WriteLine("                                                           ███████████");
                                }

                                if (a3 == 'a')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine();

                                }
                                else if (a3 == 'b')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine();
                                }
                                else if (a3 == 'c')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███");
                                    Console.WriteLine("                                         ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████");
                                }
                                else if (a3 == 'd')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ████████");
                                }
                                else if (a3 == 'e')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███████████");
                                }
                                else if (a3 == 'f')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                }
                                else if (a3 == 'g')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███");
                                    Console.WriteLine("                                         ███   █████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████  ");
                                }
                                else if (a3 == 'h')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                }
                                else if (a3 == 'i')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                          █████████ ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                          █████████ ");
                                }
                                else if (a3 == 'j')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                                 ███");
                                    Console.WriteLine("                                                 ███");
                                    Console.WriteLine("                                                 ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████   ");
                                }
                                else if (a3 == 'k')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███  ███   ");
                                    Console.WriteLine("                                         ██████     ");
                                    Console.WriteLine("                                         ███  ███   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                }
                                else if (a3 == 'l')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███████████");
                                }
                                else if (a3 == 'm')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ██       ██");
                                    Console.WriteLine("                                         ████   ████");
                                    Console.WriteLine("                                         ██  ███  ██");
                                    Console.WriteLine("                                         ██       ██");
                                    Console.WriteLine("                                         ██       ██");
                                    Console.WriteLine("                                         ██       ██");
                                }
                                else if (a3 == 'n')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ██████  ███");
                                    Console.WriteLine("                                         ███  ██████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                }
                                else if (a3 == 'o')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████   ");
                                }
                                else if (a3 == 'p')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ████████   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ████████   ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███        ");
                                }
                                else if (a3 == 'q')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████   ");
                                    Console.WriteLine("                                         ███    ███");
                                    Console.WriteLine("                                         ███    ███");
                                    Console.WriteLine("                                         ███    ███");
                                    Console.WriteLine("                                         ███    ███");
                                    Console.WriteLine("                                            ████████");
                                }
                                else if (a3 == 'r')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ████████   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ████████");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                }
                                else if (a3 == 's')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                            █████   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            ███     ");
                                    Console.WriteLine("                                              ███      ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████   ");
                                }
                                else if (a3 == 't')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                }
                                else if (a3 == 'u')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███████████");
                                }
                                else if (a3 == 'v')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████   ");
                                }
                                else if (a3 == 'w')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ██      ██");
                                    Console.WriteLine("                                         ██      ██");
                                    Console.WriteLine("                                         ██      ██");
                                    Console.WriteLine("                                         ██  ██  ██");
                                    Console.WriteLine("                                         ██  ██  ██");
                                    Console.WriteLine("                                           ██  ██  ");
                                }
                                else if (a3 == 'x')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                            █████   ");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                    Console.WriteLine("                                         ███     ███");
                                }
                                else if (a3 == 'y')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ██       ██");
                                    Console.WriteLine("                                         ██       ██");
                                    Console.WriteLine("                                           ██   ██  ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                    Console.WriteLine("                                             ███    ");
                                }
                                else if (a3 == 'z')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                                         ███████████");
                                    Console.WriteLine("                                                 ███");
                                    Console.WriteLine("                                               ███  ");
                                    Console.WriteLine("                                            ███     ");
                                    Console.WriteLine("                                         ███        ");
                                    Console.WriteLine("                                         ███████████");
                                }

                                if (a2 == 'a')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine();

                                }
                                else if (a2 == 'b')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine();
                                }
                                else if (a2 == 'c')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███");
                                    Console.WriteLine("                       ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████");
                                }
                                else if (a2 == 'd')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ████████");
                                }
                                else if (a2 == 'e')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███████████");
                                }
                                else if (a2 == 'f')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                }
                                else if (a2 == 'g')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███");
                                    Console.WriteLine("                       ███   █████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████  ");
                                }
                                else if (a2 == 'h')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                }
                                else if (a2 == 'i')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                        █████████ ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                        █████████ ");
                                }
                                else if (a2 == 'j')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                               ███");
                                    Console.WriteLine("                               ███");
                                    Console.WriteLine("                               ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████   ");
                                }
                                else if (a2 == 'k')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███  ███   ");
                                    Console.WriteLine("                       ██████     ");
                                    Console.WriteLine("                       ███  ███   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                }
                                else if (a2 == 'l')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███████████");
                                }
                                else if (a2 == 'm')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ██       ██");
                                    Console.WriteLine("                       ████   ████");
                                    Console.WriteLine("                       ██  ███  ██");
                                    Console.WriteLine("                       ██       ██");
                                    Console.WriteLine("                       ██       ██");
                                    Console.WriteLine("                       ██       ██");
                                }
                                else if (a2 == 'n')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ██████  ███");
                                    Console.WriteLine("                       ███  ██████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                }
                                else if (a2 == 'o')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████   ");
                                }
                                else if (a2 == 'p')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ████████   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ████████   ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███        ");
                                }
                                else if (a2 == 'q')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████   ");
                                    Console.WriteLine("                       ███    ███");
                                    Console.WriteLine("                       ███    ███");
                                    Console.WriteLine("                       ███    ███");
                                    Console.WriteLine("                       ███    ███");
                                    Console.WriteLine("                          ████████");
                                }
                                else if (a2 == 'r')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ████████   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ████████");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                }
                                else if (a2 == 's')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                          █████   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          ███     ");
                                    Console.WriteLine("                            ███      ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████   ");
                                }
                                else if (a2 == 't')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                }
                                else if (a2 == 'u')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███████████");
                                }
                                else if (a2 == 'v')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████   ");
                                }
                                else if (a2 == 'w')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ██      ██");
                                    Console.WriteLine("                       ██      ██");
                                    Console.WriteLine("                       ██      ██");
                                    Console.WriteLine("                       ██  ██  ██");
                                    Console.WriteLine("                       ██  ██  ██");
                                    Console.WriteLine("                         ██  ██  ");
                                }
                                else if (a2 == 'x')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                          █████   ");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                    Console.WriteLine("                       ███     ███");
                                }
                                else if (a2 == 'y')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ██       ██");
                                    Console.WriteLine("                       ██       ██");
                                    Console.WriteLine("                         ██   ██  ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                    Console.WriteLine("                           ███    ");
                                }
                                else if (a2 == 'z')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("                       ███████████");
                                    Console.WriteLine("                               ███");
                                    Console.WriteLine("                             ███  ");
                                    Console.WriteLine("                          ███     ");
                                    Console.WriteLine("                       ███        ");
                                    Console.WriteLine("                       ███████████");
                                }

                                if (a1 == 'a')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine();

                                }
                                else if (a1 == 'b')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine();
                                }
                                else if (a1 == 'c')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███");
                                    Console.WriteLine("     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████");
                                }
                                else if (a1 == 'd')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ████████");
                                }
                                else if (a1 == 'e')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███████████");
                                }
                                else if (a1 == 'f')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                }
                                else if (a1 == 'g')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███");
                                    Console.WriteLine("     ███   █████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████  ");
                                }
                                else if (a1 == 'h')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                }
                                else if (a1 == 'i')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("      █████████ ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("      █████████ ");
                                }
                                else if (a1 == 'j')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("             ███");
                                    Console.WriteLine("             ███");
                                    Console.WriteLine("             ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████   ");
                                }
                                else if (a1 == 'k')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███  ███   ");
                                    Console.WriteLine("     ██████     ");
                                    Console.WriteLine("     ███  ███   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                }
                                else if (a1 == 'l')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███████████");
                                }
                                else if (a1 == 'm')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ██       ██");
                                    Console.WriteLine("     ████   ████");
                                    Console.WriteLine("     ██  ███  ██");
                                    Console.WriteLine("     ██       ██");
                                    Console.WriteLine("     ██       ██");
                                    Console.WriteLine("     ██       ██");
                                }
                                else if (a1 == 'n')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ██████  ███");
                                    Console.WriteLine("     ███  ██████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                }
                                else if (a1 == 'o')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████   ");
                                }
                                else if (a1 == 'p')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ████████   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ████████   ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███        ");
                                }
                                else if (a1 == 'q')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████   ");
                                    Console.WriteLine("     ███    ███");
                                    Console.WriteLine("     ███    ███");
                                    Console.WriteLine("     ███    ███");
                                    Console.WriteLine("     ███    ███");
                                    Console.WriteLine("        ████████");
                                }
                                else if (a1 == 'r')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ████████   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ████████");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                }
                                else if (a1 == 's')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("        █████   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        ███     ");
                                    Console.WriteLine("          ███      ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████   ");
                                }
                                else if (a1 == 't')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                }
                                else if (a1 == 'u')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███████████");
                                }
                                else if (a1 == 'v')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████   ");
                                }
                                else if (a1 == 'w')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ██      ██");
                                    Console.WriteLine("     ██      ██");
                                    Console.WriteLine("     ██      ██");
                                    Console.WriteLine("     ██  ██  ██");
                                    Console.WriteLine("     ██  ██  ██");
                                    Console.WriteLine("       ██  ██  ");
                                }
                                else if (a1 == 'x')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("        █████   ");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                    Console.WriteLine("     ███     ███");
                                }
                                else if (a1 == 'y')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ██       ██");
                                    Console.WriteLine("     ██       ██");
                                    Console.WriteLine("       ██   ██  ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                    Console.WriteLine("         ███    ");
                                }
                                else if (a1 == 'z')
                                {
                                    Console.SetCursorPosition(0, 5);
                                    Console.WriteLine("     ███████████");
                                    Console.WriteLine("             ███");
                                    Console.WriteLine("           ███  ");
                                    Console.WriteLine("        ███     ");
                                    Console.WriteLine("     ███        ");
                                    Console.WriteLine("     ███████████");
                                }
                                Thread.Sleep(100);
                            }
                            Thread.Sleep(1500);
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("A menübe való visszalépéshez nyomj m-et!");
                            Console.WriteLine("A kilépéshez nyomj esc-et");



                        }
                        else Console.WriteLine("Sajnos hibás az adatbevitel");

                        #endregion

                        while (true)
                        {
                            ConsoleKeyInfo cki;
                            cki = Console.ReadKey();
                            if (cki.KeyChar == 'm')
                            {
                                start = start + 1;
                                break;
                            }
                            else
                            {
                                System.Environment.Exit(0);
                                break;
                            }
                        }

                        break;
                    }
                    else if (result.KeyChar == '2')
                    {
                        Thread.Sleep(500);
                        Console.SetCursorPosition(11, 8);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2. Rajz robot betöltése...");
                        Thread.Sleep(2000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();

                        Console.SetCursorPosition(2, 8);
                        Console.WriteLine("Üdv! Kérlek válaszd ki, hogy mit rajzoljak neked!");
                        Console.WriteLine();
                        Console.WriteLine("       1. Pokéball                      ");
                        Console.WriteLine();
                        Console.WriteLine("       2. Iron Man                      ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        while (true)
                        {
                            ConsoleKeyInfo melyikrajz = Console.ReadKey();
                            if (melyikrajz.KeyChar == '1')
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                #region pokelabda
                                Console.SetWindowSize(34, 17);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                for (int rajz1 = 0; rajz1 < 21; rajz1++)
                                {
                                    Console.WriteLine("████████████████████████████████████████");
                                }
                                Console.SetCursorPosition(0, 0);

                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(12, 1);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 2);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 2);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 3);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(26, 3);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(28, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 5);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(28, 5);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(2, 6);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(30, 6);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(2, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(14, 7);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(30, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(2, 8);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(26, 8);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(2, 9);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 9);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(30, 9);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(2, 10);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 10);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 11);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(14, 11);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(28, 11);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 12);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(28, 12);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 13);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(26, 13);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 14);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 14);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 15);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(12, 2);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 3);
                                Console.WriteLine("██████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 4);
                                Console.WriteLine("██████████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 5);
                                Console.WriteLine("██████████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 6);
                                Console.WriteLine("██████████████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 7);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 7);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 8);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 8);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(14, 8);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(14, 9);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(14, 10);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(4, 9);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(26, 9);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(4, 10);
                                Console.WriteLine("████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 10);
                                Console.WriteLine("████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 11);
                                Console.WriteLine("████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 11);
                                Console.WriteLine("████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(6, 12);
                                Console.WriteLine("██████████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 13);
                                Console.WriteLine("██████████████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 14);
                                Console.WriteLine("██████████");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(12, 4);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("  Menü: m");
                                while (true)
                                {
                                    ConsoleKeyInfo cki;
                                    cki = Console.ReadKey();
                                    if (cki.KeyChar == 'm')
                                    {
                                        start = start + 1;
                                        break;
                                    }
                                    else
                                    {
                                        System.Environment.Exit(0);
                                        break;
                                    }
                                }

                                break;
                                #endregion
                            }
                            else if (melyikrajz.KeyChar == '2')
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                #region ironman

                                Console.SetWindowSize(34, 17);
                                Console.ForegroundColor = ConsoleColor.Black;
                                for (int rajz1 = 0; rajz1 < 21; rajz1++)
                                {
                                    Console.WriteLine("████████████████████████████████████████");
                                }
                                Console.SetCursorPosition(0, 0);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(12, 1);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 2);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(14, 2);
                                Console.WriteLine("██████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 2);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 3);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(16, 3);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 3);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 5);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 5);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 7);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(24, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(8, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 8);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(18, 8);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(24, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 9);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 11);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(18, 11);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(12, 2);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 2);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 3);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(18, 3);
                                Console.WriteLine("████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(16, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 5);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 6);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(20, 6);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 7);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(10, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(22, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(12, 10);
                                Console.WriteLine("██████████");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(14, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(18, 4);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(16, 8);
                                Console.WriteLine("██");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.SetCursorPosition(14, 6);
                                Console.WriteLine("██████");
                                Thread.Sleep(1500);
                                Console.SetCursorPosition(12, 13);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;                              
                                Console.WriteLine(" Menü: m ");
                                while (true)
                                {
                                    ConsoleKeyInfo cki;
                                    cki = Console.ReadKey();
                                    if (cki.KeyChar == 'm')
                                    {
                                        start = start + 1;
                                        break;
                                    }
                                    else
                                    {
                                        System.Environment.Exit(0);
                                        break;
                                    }
                                }

                                break;
                                #endregion
                            }
                            else
                            {
                                System.Environment.Exit(0);
                                break;
                            }
                        }

                        break;
                    }
                    else if (result.KeyChar == '3')
                    {
                        Thread.Sleep(500);
                        Console.SetCursorPosition(11, 9);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("3. Kígyózó betöltése...");
                        Thread.Sleep(2000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();


                        #region kígyó
                        Console.SetWindowSize(80, 20);
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.SetCursorPosition(35, 5);
                        Console.WriteLine("HOGYAN JÁTTSZ?");
                        Console.SetCursorPosition(15, 7);
                        Console.WriteLine("A játék célja, hogy 70 lépésből felszedd");
                        Console.SetCursorPosition(15, 8);
                        Console.WriteLine("mind az öt csillagot a kígyóval.");
                        Console.SetCursorPosition(15, 9);
                        Console.WriteLine("Ha kimész a képernyőről, vagy ha letelik");
                        Console.SetCursorPosition(15, 110);
                        Console.WriteLine("a körszám, vesztettél.");
                        Console.SetCursorPosition(15, 14);
                        Console.WriteLine("Irányítás: W A S D gombokkal");
                        Console.SetCursorPosition(15, 15);
                        Console.WriteLine("Nyomj meg egy gombot a kezdéshez!");
                        Console.SetCursorPosition(0, 0);
                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.SetWindowSize(80, 20);
                        int x = 10;
                        int y = 40;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int ax = rnd.Next(1, 9) * 2;
                        int ay = rnd.Next(1, 39) * 2;
                        int bx = rnd.Next(1, 9) * 2;
                        int by = rnd.Next(1, 39) * 2;
                        int cx = rnd.Next(1, 9) * 2;
                        int cy = rnd.Next(1, 39) * 2;
                        int dx = rnd.Next(1, 9) * 2;
                        int dy = rnd.Next(1, 39) * 2;
                        int ex = rnd.Next(1, 9) * 2;
                        int ey = rnd.Next(1, 39) * 2;
                        Console.SetCursorPosition(ay, ax);
                        Console.WriteLine("* ");
                        Console.SetCursorPosition(by, bx);
                        Console.WriteLine("* ");
                        Console.SetCursorPosition(cy, cx);
                        Console.WriteLine("* ");
                        Console.SetCursorPosition(dy, dx);
                        Console.WriteLine("* ");
                        Console.SetCursorPosition(ey, ex);
                        Console.WriteLine("* ");

                        int csillag1 = 0;
                        int csillag2 = 0;
                        int csillag3 = 0;
                        int csillag4 = 0;
                        int csillag5 = 0;

                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("████████████████████████████████████████████████████████████████████████████████");
                        Console.SetCursorPosition(0, 19);
                        Console.Write("████████████████████████████████████████████████████████████████████████████████");

                        for (int szinker = 0; szinker < 20; szinker++)
                        {
                            Console.SetCursorPosition(0, szinker);
                            Console.WriteLine("██");
                            Console.SetCursorPosition(78, szinker);
                            Console.WriteLine("██");
                        }

                        int eredmeny = 0;
                        for (int kigyo = 0; kigyo < 70; kigyo++)
                        {
                            int csillag = csillag1 + csillag2 + csillag3 + csillag4 + csillag5;
                            Console.SetCursorPosition(2, 0);
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Begyűjtött csillagok: ");
                            Console.SetCursorPosition(2, 19);
                            Console.Write($"Hátralévő körök: {70 - kigyo}");
                            Console.SetCursorPosition(25, 0);
                            for (int cs = 0; cs < csillag; cs++)
                            {

                                Console.Write(" *");
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(y, x);
                            Console.Write("██");
                            Console.ForegroundColor = ConsoleColor.Black;
                            while (true)
                            {
                                ConsoleKeyInfo gomba = Console.ReadKey(true);
                                if (gomba.KeyChar == 's')
                                {
                                    x = x + 1;

                                    break;
                                }
                                else if (gomba.KeyChar == 'w')
                                {
                                    x = x + -1;

                                    break;
                                }
                                else if (gomba.KeyChar == 'a')
                                {

                                    y = y - 2;

                                    break;
                                }
                                else if (gomba.KeyChar == 'd')
                                {
                                    y = y + 2;

                                    break;
                                }
                                else
                                { kigyo = kigyo + 1; break; }

                            }
                            if (x == ax && y == ay)
                            {
                                csillag1 = csillag1 + 1;
                            }
                            if (x == bx && y == by)
                            {
                                csillag2 = csillag2 + 1;
                            }
                            if (x == cx && y == cy)
                            {
                                csillag3 = csillag3 + 1;
                            }
                            if (x == dx && y == dy)
                            {
                                csillag3 = csillag3 + 1;
                            }
                            if (x == ex && y == ey)
                            {
                                csillag3 = csillag3 + 1;
                            }
                            if (x == 20 || y == 80 || x == 0 || y == 0)
                            {
                                Thread.Sleep(500);
                                eredmeny = eredmeny + 400;
                                kigyo = kigyo + 300;
                            }
                            if (csillag == 5)
                            {
                                Thread.Sleep(500);
                                eredmeny = eredmeny + 300;
                                kigyo = kigyo + 300;
                            }


                        }
                        if (eredmeny == 0 || eredmeny == 400)
                        {
                            Thread.Sleep(1000);
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.SetCursorPosition(35, 9);
                            Console.WriteLine("VESZTETTÉL!");
                            Console.SetCursorPosition(35, 12);
                            Console.WriteLine("MENÜ: m");
                            Thread.Sleep(1000);
                            while (true)
                            {
                                ConsoleKeyInfo cki;
                                cki = Console.ReadKey();
                                if (cki.KeyChar == 'm')
                                {
                                    start = start + 1;
                                    break;
                                }

                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Rossz gomb, visszatérés a menübe...");
                                    Thread.Sleep(1000);
                                    break;
                                }
                            }

                            break;

                        }

                        if (eredmeny == 300)
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.SetCursorPosition(35, 7);
                            Console.WriteLine("GRATULÁLOK!");
                            Console.SetCursorPosition(35, 9);
                            Console.WriteLine("NYERTÉL!");
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("MENÜ: m");
                            while (true)
                            {
                                ConsoleKeyInfo cki;
                                cki = Console.ReadKey();
                                if (cki.KeyChar == 'm')
                                {
                                    start = start + 1;
                                    break;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                    break;
                                }
                            }

                            break;

                        }
                        #endregion
                        break;
                    }
                    else if (result.Key == ConsoleKey.Escape)
                    {
                        start = start + 20;
                        break;
                    }
                    else
                    { start = start + 1; break; }

                }




                
            }
        }
    }
}
