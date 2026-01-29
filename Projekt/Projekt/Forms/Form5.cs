using Newtonsoft.Json;
using Projekt.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Classes;
using System.Collections.Specialized;

namespace Projekt.Forms
{
    
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
            var txt = File.ReadAllText(path);
            var dataOceny = JsonConvert.DeserializeObject<List<Ocena>>(txt);
            path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
            txt = File.ReadAllText(path);
            var dataNauczyciele = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);
            path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
            txt = File.ReadAllText(path);
            var dataUczniowie = JsonConvert.DeserializeObject<List<Uczen>>(txt);

            List<tempOcema> oceny = new List<tempOcema>();
            int id, wartoscOceny;
            string uczen = "", nauczyciel = "", przedmiot = "";

            foreach (var ocena in dataOceny)
            {
                id = ocena.ID;
                wartoscOceny = ocena.WartoscOceny;
                foreach(var n in dataNauczyciele)
                {
                    if(n.ID == ocena.IdNauczyciela)
                    {
                        nauczyciel = n.Imie;
                        nauczyciel += (" " + n.Nazwisko);
                        przedmiot = n.Przedmiot;
                    }
                }
                foreach(var u in dataUczniowie)
                {
                    if(u.ID == ocena.IDUcznia)
                    {
                        uczen = u.Imie;
                        uczen += (" " + u.Nazwisko);
                    }
                }
                oceny.Add(new tempOcema(id, wartoscOceny, uczen, nauczyciel, przedmiot));
            }

            dataGridView1.DataSource = oceny;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
            var txt = File.ReadAllText(path);
            var dataOceny = JsonConvert.DeserializeObject<List<Ocena>>(txt);
            path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
            txt = File.ReadAllText(path);
            var dataNauczyciele = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);
            path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
            txt = File.ReadAllText(path);
            var dataUczniowie = JsonConvert.DeserializeObject<List<Uczen>>(txt);

            List<tempOcema> oceny = new List<tempOcema>();
            int id, wartoscOceny;
            string uczen = "", nauczyciel = "", przedmiot = "";

            foreach (var ocena in dataOceny)
            {
                id = ocena.ID;
                wartoscOceny = ocena.WartoscOceny;
                foreach (var n in dataNauczyciele)
                {
                    if (n.ID == ocena.IdNauczyciela)
                    {
                        nauczyciel = n.Imie;
                        nauczyciel += (" " + n.Nazwisko);
                        przedmiot = n.Przedmiot;
                    }
                }
                foreach (var u in dataUczniowie)
                {
                    if (u.ID == ocena.IDUcznia)
                    {
                        uczen = u.Imie;
                        uczen += (" " + u.Nazwisko);
                    }
                }
                oceny.Add(new tempOcema(id, wartoscOceny, uczen, nauczyciel, przedmiot));
            }

            dataGridView1.DataSource = oceny;
        }
    }
}
