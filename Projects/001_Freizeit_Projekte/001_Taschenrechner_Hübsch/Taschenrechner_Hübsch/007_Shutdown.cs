using System;
using System.Threading;

namespace Taschenrechner_mit_Menue
{
	public class Shutdown
	{
		public void myShut ()
		{
            Console.Clear();
            Console.WriteLine ("Programm wird beendet");
			Thread.Sleep (1000);
			Console.Beep (800, 200);
			Console.Beep (600, 500);
			Environment.Exit (1);
		}
	}
}

