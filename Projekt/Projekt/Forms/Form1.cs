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
using Newtonsoft.Json;
using Projekt.Classes;

namespace Projekt.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NauczycielRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(NauczycielRadio.Checked)
            {
                klasaComboBox.Visible = false;
                klasaLabel.Visible = false;
                przedmiotComboBox.Visible = true;
                przedmiotLabel.Visible = true;
            }
        }

        private void uczenRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (uczenRadio.Checked)
            {
                klasaComboBox.Visible = true;
                klasaLabel.Visible = true;
                przedmiotComboBox.Visible = false;
                przedmiotLabel.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form2);
            form2.Show();
        }

        private void listaUczniowButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void listaNauczycieliButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (imieTextBox.Text != "" && nazwiskoTextBox.Text != "" && emailTextBox.Text != "" && (uczenRadio.Checked || NauczycielRadio.Checked))
            {
                if (uczenRadio.Checked)
                {
                    if (klasaComboBox.Text != "")
                    {
                        errorLabel1.Visible = false;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
                        var txt = File.ReadAllText(path);
                        var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);
                        data.Add(new Uczen(imieTextBox.Text, nazwiskoTextBox.Text, datePicker.Text, emailTextBox.Text, int.Parse(klasaComboBox.Text), data[data.Count - 1].ID + 1));

                        var json = JsonConvert.SerializeObject(data);
                        File.WriteAllText(path, json);
                    }
                    else
                    {
                        errorLabel1.Text = "Nie uzupełniono wszystkich danych";
                        errorLabel1.Visible = true;
                    }
                }
                else if (NauczycielRadio.Checked)
                {
                    if (przedmiotComboBox.Text != "")
                    {
                        errorLabel1.Visible = false;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
                        var txt = File.ReadAllText(path);
                        var data = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);
                        data.Add(new Nauczyciel(imieTextBox.Text, nazwiskoTextBox.Text, datePicker.Text, emailTextBox.Text, przedmiotComboBox.Text, data[data.Count - 1].ID + 1));

                        var json = JsonConvert.SerializeObject(data);
                        File.WriteAllText(path, json);
                    }
                    else
                    {
                        errorLabel1.Text = "Nie uzupełniono wszystkich danych";
                        errorLabel1.Visible = true;
                    }
                }
            }
            else
            {
                errorLabel1.Text = "Nie uzupełniono wszystkich danych";
                errorLabel1.Visible = true;
            }
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (nauczycielRadio2.Checked && idTextBox.Text!= "")
            {
                errorLabel2.Visible = false;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
                var txt = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);

                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].ID == int.Parse(idTextBox.Text))
                    {
                        data.RemoveAt(i);
                    }
                }

                var json = JsonConvert.SerializeObject(data);
                File.WriteAllText(path, json);
            }
            else if(uczenRadio2.Checked && idTextBox.Text != "")
            {
                errorLabel2.Visible = false;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
                var txt = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);

                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].ID == int.Parse(idTextBox.Text))
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
                errorLabel2.Visible = true;
            }
        }
    }
}
