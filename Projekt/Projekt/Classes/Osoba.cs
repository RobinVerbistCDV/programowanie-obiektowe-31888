using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    internal abstract class Osoba
    {
        protected int id;
        protected string imie;
        protected string nazwisko;
        protected string data;
        protected string email;

        public int ID { get { return id; } }
        public string Imie { get { return imie; } }
        public string Nazwisko { get { return nazwisko; } }
        public string Data { get { return data; } }
        public string Email { get { return email; } }

        public Osoba(int id, string imie, string nazwisko, string data, string email)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.data = data;
            this.email = email;
            this.id = id;
        }
    }
}
