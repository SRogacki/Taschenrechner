using System;
using System.Threading;
namespace Taschenrechner_mit_Menue
{
	public class Division
	{
		public void myDiv ()
		{
			int arrlength = 0;
			int userint = 0;

			Console.WriteLine ("*****Division*****");
			Console.WriteLine ("");
			Console.Write ("Wie viele Zahlen wollen Sie berechnen?");
			Console.Write ("");
			while (arrlength < 2) {

				int.TryParse (Console.ReadLine (), out arrlength);
				if (arrlength < 2) {
					Console.WriteLine ("Sie müssen mindestens zwei Zahlen eingeben!");
				}
			} 

			Console.Clear ();
			Console.Write ("Bitte geben Sie Ihre erste Zahl ein: ");
			int[] userIntsdiv = new int[arrlength];
			for (int i = 0; i < 1; i++) {
				string userValue = Console.ReadLine ();
				int userInt;
				if (int.TryParse (userValue, out userInt)) {
					userIntsdiv [i] = userInt;
				}


			}	



			while (userint == 0) {

				Console.WriteLine (" ");	
				Console.WriteLine ("Bitte geben Sie eine weitere Zahl ein");
				Console.WriteLine ("");

				int.TryParse (Console.ReadLine (), out userint);
				if (userint == 0) {

					Console.WriteLine (" ");
					Console.WriteLine ("Falsche Eingabe! Der Divisor dar nicht 0 sein!!!");
					Console.WriteLine ("Bitte Wiederholen Sie Ihre Eingabe");
					Console.WriteLine (" ");

				}
			} 

			for (int i = 1; i < userIntsdiv.Length; i++) {



				userIntsdiv [i] = userint;


			}
			Console.Clear ();

			int ergebnisdiv = 0;
			int counter2 = 0;

			foreach (int ui  in userIntsdiv) {
				counter2++;	


				if (counter2 == 1) {

					ergebnisdiv = ui;
					continue;

				}
				ergebnisdiv = ergebnisdiv / ui;

			}
			Console.Clear ();
			Console.WriteLine ("Zahlen werden berechnet...");
			Console.WriteLine ();
			Thread.Sleep (1500);
			Console.WriteLine ("Das Ergebnis lautet: " + ergebnisdiv);
			Thread.Sleep(2000);

			Untermenue instanzUntermenue = new Untermenue ();
			instanzUntermenue.myUntermenue ();

		}
	}
}