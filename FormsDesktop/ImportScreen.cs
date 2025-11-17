using FormsDesktop.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

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

            string selectedJsonContent = File.ReadAllText(dialog.FileName);

            try
            {
                using JsonDocument doc = JsonDocument.Parse(selectedJsonContent);
                var root = doc.RootElement;

                string game = null;
                JsonElement array;

                if (root.TryGetProperty("cat", out array)) game = "cat";
                else if (root.TryGetProperty("colors", out array)) game = "colors";

                if (game == null)
                {
                    MessageBox.Show("JSON no corresponde a ningún juego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isValid = true;

                foreach (var item in array.EnumerateArray())
                {
                    if (game == "cat" && (!item.TryGetProperty("name", out _) || !item.TryGetProperty("age", out _)))
                        isValid = false;
                    else if (game == "colors" && (!item.TryGetProperty("name", out _) || !item.TryGetProperty("hex", out _)))
                        isValid = false;

                    if (!isValid) break;
                }

                if (!isValid)
                {
                    MessageBox.Show($"JSON inválido para {game}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Deserializamos el JSON a los objetos correspondientes
                if (game == "cat")
                {
                    catusers = JsonSerializer.Deserialize<List<CatUser>>(array.GetRawText());
                }
                else if (game == "colors")
                {
                    colorsUsers = JsonSerializer.Deserialize<List<ColorsUser>>(array.GetRawText());
                }

                MessageBox.Show($"JSON válido para {game} y cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (game == "cat")
                {
                    LeadingPage lp = new LeadingPage(catusers);
                    lp.Show();
                }
                else
                {
                    LeadingPage lp = new LeadingPage(colorsUsers);
                    lp.Show();
                }


            }
            catch (JsonException)
            {
                MessageBox.Show("JSON no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
