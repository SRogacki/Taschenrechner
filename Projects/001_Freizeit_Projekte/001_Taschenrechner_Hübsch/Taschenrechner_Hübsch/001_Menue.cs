using System;
using System.Threading;

namespace Taschenrechner_mit_Menue
{
	public class Menue
	{


        public void myMenue ()
		{
            
            int navigation = 1;
            bool schleife = true;


            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop+13);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" T A S C H E N R E C H N E R ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
            Console.WriteLine("********************");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 12 / 2, Console.CursorTop);
            Console.WriteLine(">>Addition<<");
            Console.Beep(600, 200);
            Console.Beep(800, 500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
            Console.WriteLine("Subtraktion");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 14 / 2, Console.CursorTop);
            Console.WriteLine("Multiplikation");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
            Console.WriteLine("Division");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7 / 2, Console.CursorTop);
            Console.WriteLine("Beenden");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
            Console.WriteLine("********************");
            Console.SetCursorPosition(0, 29);

            Rahmen RahmenCase1 = new Rahmen();
            RahmenCase1.myRahmen();

            while (schleife == true)
            {
                ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.Escape)
                {
                    Shutdown ShutdownMenue = new Shutdown();
                    ShutdownMenue.myShut();


                }

                if (k.Key == ConsoleKey.Enter)
                {
                    Console.Clear();


                    switch (navigation)
                    {
                        case 1:
                            Addition instanzAdd = new Addition();
                            instanzAdd.myAdd();
                            Console.ReadLine();


                            break;

                        case 2:
                            Subtraktion instanzSub = new Subtraktion();
                            instanzSub.mySub();
                            Console.ReadLine();


                            break;

                        case 3:
                            Multiplikation instanzMult = new Multiplikation();
                            instanzMult.myMulti();
                            Console.ReadLine();



                            break;

                        case 4:
                            Division instanzDiv = new Division();
                            instanzDiv.myDiv();
                            Console.ReadLine();


                            break;


                        case 5:
                            Shutdown instanzShut = new Shutdown();
                            instanzShut.myShut();


                            break;
                    }

                    break;

                }

                if (k.Key == ConsoleKey.UpArrow)
                {
                    if (navigation != 1)
                        navigation--;

                    else
                        navigation = 5;

                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    if (navigation != 5)
                        navigation++;
                    else
                        navigation = 1;
                }
                if (navigation == 1 || k.Key == ConsoleKey.Add)
                {

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop + 13);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" T A S C H E N R E C H N E R ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
                    Console.WriteLine("********************");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 12 / 2, Console.CursorTop);
                    Console.WriteLine(">>Addition<<");
                    Console.Beep(600, 200);
                    Console.Beep(800, 500);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
                    Console.WriteLine("Subtraktion");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 14 / 2, Console.CursorTop);
                    Console.WriteLine("Multiplikation");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Division");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7 / 2, Console.CursorTop);
                    Console.WriteLine("Beenden");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
                    Console.WriteLine("********************");
                    Console.SetCursorPosition(0, 29);
                }
                else if (navigation == 2)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop + 13);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" T A S C H E N R E C H N E R ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
                    Console.WriteLine("********************");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Addition");
                    Console.Beep(600, 200);
                    Console.Beep(800, 500);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 15 / 2, Console.CursorTop);
                    Console.WriteLine(">>Subtraktion<<");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 14 / 2, Console.CursorTop);
                    Console.WriteLine("Multiplikation");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Division");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7 / 2, Console.CursorTop);
                    Console.WriteLine("Beenden");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
                    Console.WriteLine("********************");
                   
                }
                else if (navigation == 3)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop + 13);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" T A S C H E N R E C H N E R ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
                    Console.WriteLine("********************");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Addition");
                    Console.Beep(600, 200);
                    Console.Beep(800, 500);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
                    Console.WriteLine("Subtraktion");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 19 / 2, Console.CursorTop);
                    Console.WriteLine(">>Multiplikation<<");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Division");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7 / 2, Console.CursorTop);
                    Console.WriteLine("Beenden");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
                    Console.WriteLine("********************");

                }
                else if (navigation == 4)
                {
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop + 13);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" T A S C H E N R E C H N E R ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
                    Console.WriteLine("********************");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Addition");
                    Console.Beep(600, 200);
                    Console.Beep(800, 500);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
                    Console.WriteLine("Subtraktion");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 14 / 2, Console.CursorTop);
                    Console.WriteLine("Multiplikation");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 12 / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(">>Division<<");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7 / 2, Console.CursorTop);
                    Console.WriteLine("Beenden");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
                    Console.WriteLine("********************");
                   
                }
                else if (navigation == 5)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 29 / 2, System.Console.CursorTop + 13);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" T A S C H E N R E C H N E R ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop + 5);
                    Console.WriteLine("********************");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Addition");
                    Console.Beep(600, 200);
                    Console.Beep(800, 500);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
                    Console.WriteLine("Subtraktion");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 14 / 2, Console.CursorTop);
                    Console.WriteLine("Multiplikation");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 8 / 2, Console.CursorTop);
                    Console.WriteLine("Division");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 11 / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(">>Beenden<<");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 20 / 2, Console.CursorTop);
                    Console.WriteLine("********************");

                }
                Rahmen RahmenCase2 = new Rahmen();
                RahmenCase2.myRahmen();
            }
        }
    }
}
