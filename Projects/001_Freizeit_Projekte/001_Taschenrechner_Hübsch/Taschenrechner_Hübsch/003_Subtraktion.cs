using System;
using System.Threading;

namespace Taschenrechner_mit_Menue
{
	public class Subtraktion
	{
		public void mySub ()
		{
			int arrlength = 0;


            Console.SetCursorPosition(Console.WindowWidth / 2 - 23 / 2, System.Console.CursorTop + 13);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" S U B T R A K T I O N ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 38 / 2, System.Console.CursorTop + 5);
            Console.WriteLine("Wie viele Zahlen wollen Sie berechnen?");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 2);


            while (arrlength < 2)
            {


                Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 2);
                int.TryParse(Console.ReadLine(), out arrlength);

                if (arrlength < 2)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 43 / 2, System.Console.CursorTop + 2);
                    Console.WriteLine("Sie müssen mindestens zwei Zahlen eingeben!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 23 / 2, System.Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" S U B T R A K T I O N ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 38 / 2, System.Console.CursorTop + 2);
                    Console.WriteLine("Wie viele Zahlen wollen Sie berechnen?");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 2);
                }
			}

            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 23 / 2, System.Console.CursorTop+13);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" S U B T R A K T I O N ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 37 / 2, System.Console.CursorTop + 5);
			Console.Write ("Bitte geben Sie Ihre erste Zahl ein.");
			long[] userIntsminus = new long[arrlength];

			for (int i = 0; i < arrlength; i++) {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 3);
                string userValue = Console.ReadLine ();
				long userInt;
				if (long.TryParse (userValue, out userInt)) {
					userIntsminus [i] = userInt;
				}

                Console.SetCursorPosition(Console.WindowWidth / 2 - 39 / 2, System.Console.CursorTop + 5);
				Console.Write ("Bitte geben Sie eine weitere Zahl ein: ");
			}

			Console.Clear ();

			long ergebnisminus = 0;

			for (int i = 1; i < userIntsminus.Length; i++) {
				ergebnisminus += userIntsminus [i];
			}
			long endergebnis = userIntsminus [0] - ergebnisminus;
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26 / 2, System.Console.CursorTop + 5);
            Console.WriteLine("Zahlen werden berechnet...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26 / 2, System.Console.CursorTop + 5);
            Console.WriteLine("Das Ergebnis lautet: " + endergebnis);
            Thread.Sleep(2000);
			
            Untermenue instanzUntermenue = new Untermenue ();
			instanzUntermenue.myUntermenue ();
		}
	}
}