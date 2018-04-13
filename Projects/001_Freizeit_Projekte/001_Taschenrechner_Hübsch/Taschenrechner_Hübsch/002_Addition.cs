using System;
using System.Threading;
namespace Taschenrechner_mit_Menue

{
	public class Addition
	{
		public void myAdd ()
		{
			int arrlength = 0;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 17 / 2, System.Console.CursorTop+13);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" A D D I T I O N ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 38 / 2, System.Console.CursorTop+5);
            Console.WriteLine ("Wie viele Zahlen wollen Sie berechnen?");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop+2);


			while (arrlength < 2) {


                Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 2);
				int.TryParse (Console.ReadLine (), out arrlength);
				
                if (arrlength < 2) {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 43 / 2, System.Console.CursorTop + 2);
                    Console.WriteLine ("Sie müssen mindestens zwei Zahlen eingeben!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 17 / 2, System.Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" A D D I T I O N ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 38 / 2, System.Console.CursorTop + 2);
                    Console.WriteLine("Wie viele Zahlen wollen Sie berechnen?");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 2);
				}
			}
         
			Console.Clear ();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 37 / 2, System.Console.CursorTop + 5);
            Console.WriteLine ("Bitte geben Sie Ihre erste Zahl ein.");

			long[] userIntsplus = new long[arrlength];

			for (int i = 0; i < userIntsplus.Length; i++) {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1 / 2, System.Console.CursorTop + 3);
                string userValue = Console.ReadLine ();
				long userInt;
				if (long.TryParse (userValue, out userInt)) {
					userIntsplus [i] = userInt;
				}

                Console.SetCursorPosition(Console.WindowWidth / 2 - 39 / 2, System.Console.CursorTop + 5);
				Console.Write ("Bitte geben Sie eine weitere Zahl ein.");
			}

			Console.Clear ();

			long ergebnis = 0;

			foreach (long ui in userIntsplus) {
				ergebnis += ui;
			}
			Console.Clear ();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26 / 2, System.Console.CursorTop + 5);
            Console.WriteLine ("Zahlen werden berechnet...");
			Thread.Sleep (1000);
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26 / 2, System.Console.CursorTop + 5);
            Console.WriteLine ("Das Ergebnis lautet: " + ergebnis);
			Thread.Sleep(2000);


			Untermenue instanzUntermenue = new Untermenue ();
			instanzUntermenue.myUntermenue ();


		}
	}
}

