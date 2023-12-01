using System;
using System.Collections.Generic;
using System.Linq;

namespace Notenrechner
{
    public class Notenrechner
    {
        private List<Fach> _faecher;

        public Notenrechner()
        {
            _faecher = new List<Fach>();
        }

        public void AddFach(Fach fach)
        {
            _faecher.Add(fach);
        }

        public double BerechneGesamtschnitt()
        {
            if (_faecher.Count == 0)
                return 0.0;

            double gesamtschnitt = _faecher.Sum(fach => fach.BerechneNotenschnitt() * fach.Gewichtungsfaktor) /
                                   _faecher.Sum(fach => fach.Gewichtungsfaktor);
            // Rundung auf halbe Note
            return Math.Round(gesamtschnitt * 2.0) / 2.0;
        }
    }
}
