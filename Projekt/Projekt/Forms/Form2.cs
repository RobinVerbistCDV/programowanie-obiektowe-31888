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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Dock = DockStyle.Fill;
            form1.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form1);
            form1.Show();
        }

        private void edytujRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(edytujRadio.Checked) { nowaLabel.Visible = true; nowaComboBox.Visible = true; }
            else { nowaLabel.Visible = false; nowaComboBox.Visible = false; }
        }

        private void wystawButton_Click(object sender, EventArgs e)
        {
            if (idUczniaTextBox.Text != null && idNauczycielaTextBox.Text != null && ocenaComboBox.Text != null)
            {
                errorLabel1.Visible = false;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
                var txt = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<Ocena>>(txt);

                data.Add(new Ocena(data[data.Count-1].ID+1, int.Parse(idUczniaTextBox.Text), int.Parse(idNauczycielaTextBox.Text), int.Parse(ocenaComboBox.Text)));

                var json = JsonConvert.SerializeObject(data);
                File.WriteAllText(path, json);
            }
            else
            {
                errorLabel1.Text = "Nie uzupełniono wszystkich danych";
                errorLabel1.Visible = false;
            }
        }

        private void edytujUsunButton_Click(object sender, EventArgs e)
        {
            if (idOcenyTextBox.Text != null)
            {
                if (edytujRadio.Checked)
                {
                    if(nowaComboBox.Text != null)
                    {
                        errorLabel1.Visible = false;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
                        var txt = File.ReadAllText(path);
                        var data = JsonConvert.DeserializeObject<List<Ocena>>(txt);

                        foreach(var ocena in data)
                        {
                            if(ocena.ID == int.Parse(idOcenyTextBox.Text))
                            {
                                ocena.WartoscOceny = int.Parse(nowaComboBox.Text);
                            }
                        }

                        var json = JsonConvert.SerializeObject(data);
                        File.WriteAllText(path, json);
                    }
                    else
                    {
                        errorLabel2.Text = "Nie uzupełniono wszystkich danych";
                        errorLabel2.Visible = false;
                    }
                }
                else if (usunRadio.Checked)
                {
                    errorLabel1.Visible = false;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
                    var txt = File.ReadAllText(path);
                    var data = JsonConvert.DeserializeObject<List<Ocena>>(txt);

                    for(int i = 0; i < data.Count; i++)
                    {
                        if (data[i].ID == int.Parse(idOcenyTextBox.Text))
                        {
                            data.RemoveAt(i);
                        }
                    }

                    var json = JsonConvert.SerializeObject(data);
                    File.WriteAllText(path, json);
                }
                else
                {
                    errorLabel2.Text = "Nie uzupełniono wszystkich danych";
                    errorLabel2.Visible = false;
                }
            }
            else
            {
                errorLabel2.Text = "Nie uzupełniono wszystkich danych";
                errorLabel2.Visible = false;
            }
        }

        private void sredniaButton_Click(object sender, EventArgs e)
        {
            if (idUczniaTextBox.Text != null && przedmiotComboBox.Text != null)
            {
                float wynik = 0;
                int suma = 0;
                int iloscOcen = 0;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "oceny.json");
                var txt = File.ReadAllText(path);
                var dataOceny = JsonConvert.DeserializeObject<List<Ocena>>(txt);
                path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
                txt = File.ReadAllText(path);
                var dataNauczyciele = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);

                for (int i = 0; i < dataOceny.Count; i++)
                {
                    if (dataOceny[i].IDUcznia == int.Parse(sredniaIDTextBox.Text))
                    {
                        for (int j = 0; j < dataNauczyciele.Count; j++)
                        {
                            if (dataNauczyciele[j].Przedmiot == przedmiotComboBox.Text && dataNauczyciele[j].ID == dataOceny[i].IdNauczyciela)
                            {
                                suma += dataOceny[i].WartoscOceny;
                                iloscOcen++;
                            }
                        }
                    }
                }
                if (iloscOcen > 0)
                {
                    wynik = (float)suma / (float)iloscOcen;
                    wynikLabel.Text = "Średnia: " + wynik.ToString();
                }
                else
                {
                    wynikLabel.Text = "Brak ocen";
                }
            }
            else
            {
                wynikLabel.Text = "Nie uzupełniono wszystkich danych";
            }
        }

        private void listaOcenButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
