using System;
using System.Collections.Generic;
using System.Linq;

namespace Notenrechner
{
    public class Fach
    {
        private List<double> _noten;

        public string Name { get; private set; }
        public int Gewichtungsfaktor { get; private set; }

        public Fach(string name, int gewichtungsfaktor)
        {
            Name = name;
            Gewichtungsfaktor = gewichtungsfaktor;
            _noten = new List<double>();
        }

        public void AddNote(double note)
        {
            // Prüfen und auf halbe Noten runden
            note = Math.Round(note * 2.0) / 2.0;
            _noten.Add(note);
        }

        public double BerechneNotenschnitt()
        {
            if (_noten.Count == 0)
                return 0.0;

            double schnitt = _noten.Sum() / _noten.Count;
            // Rundung auf 1/10
            return Math.Round(schnitt, 1);
        }
    }
}
