using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    internal class Nauczyciel : Osoba
    {
        private string przedmiot;
        public string Przedmiot { get { return przedmiot; } }
        public Nauczyciel(string imie, string nazwisko, string data, string email, string przedmiot, int id) : base(id, imie, nazwisko, data, email)
        {
            this.przedmiot = przedmiot;
        }
    }
}
