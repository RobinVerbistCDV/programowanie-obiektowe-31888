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

namespace Projekt.Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
            var txt = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);
            dataGridView1.DataSource = data;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "nauczyciele.json");
            var txt = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<Nauczyciel>>(txt);
            dataGridView1.DataSource = data;
        }
    }
}
