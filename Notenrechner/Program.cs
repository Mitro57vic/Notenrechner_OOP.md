using System;

namespace Notenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Notenrechner notenrechner = new Notenrechner();

            // Erstellen von Fächern und Hinzufügen zum Notenrechner
            Fach mathe = new Fach("Mathe", 2);
            Fach deutsch = new Fach("Deutsch", 1);

            notenrechner.AddFach(mathe);
            notenrechner.AddFach(deutsch);

            // Eingabe von Noten für Mathe
            Console.WriteLine("Bitte Noten für Mathe eingeben (0 zum Beenden):");
            double note;
            do
            {
                Console.Write("Note eingeben: ");
                if (double.TryParse(Console.ReadLine(), out note) && note != 0)
                {
                    mathe.AddNote(note);
                }
                else
                {
                    break;
                }
            } while (true);

            // Eingabe von Noten für Deutsch
            Console.WriteLine("Bitte Noten für Deutsch eingeben (0 zum Beenden):");
            do
            {
                Console.Write("Note eingeben: ");
                if (double.TryParse(Console.ReadLine(), out note) && note != 0)
                {
                    deutsch.AddNote(note);
                }
                else
                {
                    break;
                }
            } while (true);

            // Berechnung des Gesamtschnitts und Ausgabe
            double gesamtschnitt = notenrechner.BerechneGesamtschnitt();
            Console.WriteLine($"Der Gesamtschnitt ist: {gesamtschnitt}");

            Console.ReadLine(); // Damit die Konsole offen bleibt, bis Enter gedrückt wird
        }
    }
}
