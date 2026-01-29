using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Projekt.Classes;
using System.IO;

namespace Projekt.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
            var txt = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);
            dataGridView1.DataSource = data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                int klasa = int.Parse(comboBox1.Text);
                List<Uczen> filtr = new List<Uczen>();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
                var txt = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);
                foreach (var uczen in data)
                {
                    if (uczen.Klasa == klasa) filtr.Add(uczen);
                }
                dataGridView1.DataSource = filtr;
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
                var txt = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);
                dataGridView1.DataSource = data;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "uczniowie.json");
            var txt = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<Uczen>>(txt);
            dataGridView1.DataSource = data;
        }
    }
}
