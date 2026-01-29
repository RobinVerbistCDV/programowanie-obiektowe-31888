using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    internal class Ocena
    {
        private int id;
        private int idUcznia;
        private int idNauczyciela;
        private int wartoscOceny;

        public int ID {get{ return id; } }
        public int IDUcznia {get{ return idUcznia; } }
        public int IdNauczyciela { get { return idNauczyciela; } }
        public int WartoscOceny {get{ return wartoscOceny; }set { this.wartoscOceny = value; } }

        public Ocena(int id, int idUcznia, int idNauczyciela, int wartoscOceny)
        {
            this.id = id;
            this.idUcznia = idUcznia;
            this.idNauczyciela = idNauczyciela;
            this.wartoscOceny = wartoscOceny;
        }
    }
}
