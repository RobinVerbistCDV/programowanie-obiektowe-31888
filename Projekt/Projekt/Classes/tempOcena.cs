using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    internal class tempOcema
    {
        private int id;
        private int wartoscOceny;
        private string uczen;
        private string nauczyciel;
        private string przedmiot;

        public int ID { get { return id; } }
        public int WartoscOceny { get {  return wartoscOceny; } }
        public string Uczen { get {  return uczen; } }
        public string Nauczyciel { get { return nauczyciel; } }
        public string Przedmiot { get { return przedmiot; } }
        public tempOcema(int id, int wartoscOceny, string uczen, string nauczyciel, string przedmiot)
        {
            this.id = id;
            this.wartoscOceny = wartoscOceny;
            this.uczen = uczen;
            this.nauczyciel = nauczyciel;
            this.przedmiot = przedmiot;
        }
    }
}
