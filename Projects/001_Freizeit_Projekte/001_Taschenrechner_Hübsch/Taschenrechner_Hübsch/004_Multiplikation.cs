using System;
using System.Threading;

namespace Taschenrechner_mit_Menue
{
	public class Multiplikation
	{
		public void myMulti ()
		{
			int arrlength = 0;

			Console.WriteLine ("*****Multiplikation*****");
			Console.WriteLine ("");	
			Console.WriteLine ("Wie viele Zahlen wollen Sie berechnen?");
			Console.WriteLine ("");
			while (arrlength < 2) {

				int.TryParse (Console.ReadLine (), out arrlength);
				if (arrlength < 2) {
					Console.WriteLine ("Sie müssen mindestens zwei Zahlen eingeben!");
				}
			} 

			Console.Clear ();
			Console.Write ("Bitte geben Sie Ihre erste Zahl ein: ");
			int[] userIntsmult = new int[arrlength];

			for (int i = 0; i < userIntsmult.Length; i++) {
				string userValue = Console.ReadLine ();
				int userInt;
				if (int.TryParse (userValue, out userInt)) {
					userIntsmult [i] = userInt;
				}
				Console.Write ("Bitte geben Sie eine weitere Zahl ein: ");
			}

			Console.Clear ();

			int ergebnismult = 0;
			int counter = 0;

			foreach (int ui  in userIntsmult) {
				counter++;	


				if (counter == 1) {

					ergebnismult = ui;
					continue;

				}
				ergebnismult = ergebnismult * ui;

			}
			Console.Clear ();
			Console.WriteLine ("Zahlen werden berechnet...");
			Console.WriteLine ();
			Thread.Sleep (1500);
			Console.WriteLine ("Das Ergebnis lautet: " + ergebnismult);
			Thread.Sleep(2000);
			Untermenue instanzUntermenue = new Untermenue ();
			instanzUntermenue.myUntermenue ();
		}
	}
}

