using System;
using System.Threading;
namespace Taschenrechner_mit_Menue
{
	public class Untermenue
	{
		public void myUntermenue ()
		{
			int navigation = 1;
			bool schleife = true;
	
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.SetCursorPosition (0,20);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine (">>Hauptmenü");
			Console.Beep (600, 200);
			Console.Beep (800, 500);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine ("Beenden");

			do {
				ConsoleKeyInfo k = Console.ReadKey ();

				if(k.Key == ConsoleKey.Escape){
					
					Console.Clear();
					Console.WriteLine ("Programm wird beendet");
					Thread.Sleep (1000);
					Console.Beep (800, 200);
					Console.Beep (600, 500);
					Environment.Exit (1);
				}
				
				if (k.Key == ConsoleKey.Enter) {
					Console.Clear ();


					switch (navigation) {
						case 1:
							Menue instanzMenue = new Menue ();
							instanzMenue.myMenue ();



							break;

						case 2:
							
							Shutdown instanzShut = new Shutdown ();
							instanzShut.myShut ();



							break;



					}

					break;
				}

				if (k.Key == ConsoleKey.UpArrow)
					if (navigation != 1)
						navigation--;
					else
						navigation = 2;

				if (k.Key == ConsoleKey.DownArrow)
					if (navigation != 2)
						navigation++;
					else
						navigation = 1;

				if (navigation == 1) {
					Console.Clear();
					Console.SetCursorPosition (0,20);
					Console.BackgroundColor = ConsoleColor.DarkRed;
					Console.WriteLine (">>Hauptmenü");
					Console.Beep (500, 200);
					Console.BackgroundColor = ConsoleColor.Black;
					Console.WriteLine ("Beenden");
					Console.BackgroundColor = ConsoleColor.Black;
					;
				} else if (navigation == 2) {
					Console.Clear();
					Console.SetCursorPosition (0,20);
					Console.BackgroundColor = ConsoleColor.Black;
					Console.WriteLine ("Hauptmenü");
					Console.BackgroundColor = ConsoleColor.DarkRed;
					Console.WriteLine (">>Beenden");
					Console.Beep (600, 200);
					Console.BackgroundColor = ConsoleColor.Black;

				}
				Console.SetCursorPosition (0,20);
			} while (schleife == true);
		}
	}
}
