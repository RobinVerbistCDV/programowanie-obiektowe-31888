using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    internal class Uczen : Osoba
    {
        private int klasa;
        public int Klasa { get { return klasa; } }
        public Uczen(string imie, string nazwisko, string data, string email, int klasa, int id) : base(id, imie, nazwisko, data, email)
        {
            this.klasa = klasa;
        }
    }
}
