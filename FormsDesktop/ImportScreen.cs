using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using FormsDesktop.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonException = Newtonsoft.Json.JsonException;

namespace FormsDesktop
{
    public partial class ImportScreen : Form
    {
        private OpenFileDialog dialog = new OpenFileDialog();
        private List<CatUser> catusers = new List<CatUser>();
        private List<ColorsUser> colorsUsers = new List<ColorsUser>();

        public ImportScreen()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Archivos JSON (*.json)|*.json";
            dialog.Title = "Selecciona un JSON";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            string path = dialog.FileName;
            string json = File.ReadAllText(path);
            JObject jDatos = JObject.Parse(json);

            string game = null;
            JArray array = null;

            if (jDatos["cat"] is JArray catArray)
            {
                game = "cat";
                array = catArray;
            }
            else if (jDatos["colors"] is JArray colorsArray)
            {
                game = "colors";
                array = colorsArray;
            }

            if (game == null)
            {
                MessageBox.Show("JSON no corresponde a ningún juego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isValid = true;

            foreach (var item in array)
            {
                if (item is JObject obj)
                {
                    if (game == "cat" && (obj["name"] == null || obj["age"] == null))
                        isValid = false;
                    else if (game == "colors" && (obj["name"] == null || obj["hex"] == null))
                        isValid = false;
                }
                else
                {
                    isValid = false;
                }

                if (!isValid) break;
            }

            if (!isValid)
            {
                MessageBox.Show($"JSON inválido para {game}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deserializamos el JArray directamente a las listas
            if (game == "cat")
            {
                catusers = array.ToObject<List<CatUser>>();
            }
            else if (game == "colors")
            {
                colorsUsers = array.ToObject<List<ColorsUser>>();
            }

            MessageBox.Show($"JSON válido para {game} y cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (game == "cat")
            {
                LeadingPage lp = new LeadingPage(null, catusers);
                lp.Show();
                this.Hide();
            }
            else
            {
                LeadingPage lp = new LeadingPage(colorsUsers, null);
                lp.Show();
                this.Hide();

            }
        }
    }
}

