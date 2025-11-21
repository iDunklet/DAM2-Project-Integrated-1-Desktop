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
            button1.Location = new Point((this.ClientSize.Width  / 2)+30, (this.ClientSize.Height - button1.Height) / 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona una carpeta con JSONs";

                if (folderDialog.ShowDialog() != DialogResult.OK) return;

                string carpeta = folderDialog.SelectedPath;

                string[] archivos = Directory.GetFiles(carpeta, "*.json");

                if (archivos.Length == 0)
                {
                    MessageBox.Show("No hay archivos JSON en esta carpeta.");
                    return;
                }

                // listas finales
                catusers = new List<CatUser>();
                colorsUsers = new List<ColorsUser>();

                foreach (string path in archivos)
                {
                    try
                    {
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
                        else
                        {
                            // no corresponde a tus juegos → lo saltas
                            continue;
                        }

                        // Validación
                        bool isValid = true;

                        foreach (var item in array)
                        {
                            if (item is JObject obj)
                            {
                                if (game == "cat" && (obj["name"] == null || obj["age"] == null))
                                    isValid = false;
                                else if (game == "colors" && (obj["nombre"] == null || obj["edad"] == null))
                                    isValid = false;
                            }
                            else
                            {
                                isValid = false;
                            }

                            if (!isValid) break;
                        }

                        if (!isValid)
                            continue; // no lo cargamos

                        // Cargar datos
                        if (game == "cat")
                            catusers.AddRange(array.ToObject<List<CatUser>>());
                        else
                            colorsUsers.AddRange(array.ToObject<List<ColorsUser>>());
                    }
                    catch
                    {
                        // archivo corrupto → lo ignoramos
                        continue;
                    }
                }

                // Si no hay nada válido
                if (catusers.Count == 0 && colorsUsers.Count == 0)
                {
                    MessageBox.Show("No se pudo cargar ningún JSON válido.");
                    return;
                }

                MessageBox.Show("Archivos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir siguiente form
                LeadingPage lp = new LeadingPage(catusers, colorsUsers, carpeta);
                lp.Show();
                this.Hide();
            }
        }

    }
}

