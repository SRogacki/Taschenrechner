/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Sebastian
 * Datum: 09.04.2018
 * Zeit: 21:01
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using System.Threading;

namespace Taschenrechner_mit_Menue
{
	public class Rahmen
	{
		public void myRahmen ()
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
            int MaxWidth = Console.LargestWindowWidth;
            int MaxHeight = Console.LargestWindowHeight;

            /* Zeichnet Eine Sternchenumrahmung auf der linken und rechten Seite*/

            for (int i = 1; i < MaxHeight; i++)
            {
                Console.SetCursorPosition(MaxWidth - 2, i);       //RECHTS
                Console.WriteLine("*");
            }

;


            for (int i = 1; i < MaxHeight - 1; i++)
            {
                Console.SetCursorPosition(0, i);                //LINKS
                Console.WriteLine("*");
            }

            for (int i = 0; i < MaxWidth - 1; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("*");
            }

            for (int i = 0; i < MaxWidth - 1; i++)
            {
                Console.SetCursorPosition(i, MaxHeight - 2);
                Console.WriteLine("*");
            }

		}
	}
}