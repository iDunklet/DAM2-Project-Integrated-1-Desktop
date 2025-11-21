using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDesktop.Classes;
using FormsDesktop.Control;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;

namespace FormsDesktop
{
    public partial class LeadingPage : Form
    {

        private List<String> archivosJson;
        private String directoryPath;
        private List<CatUser> catusers = new List<CatUser>();
        private List<ColorsUser> colorsUsers = new List<ColorsUser>();
        private string filePath;
        private string filePathCat;
        private string filePathColors;

        public LeadingPage(List<CatUser> catusers, List<ColorsUser> colorsUsers, String directoryPath)
        {
            InitializeComponent();
            this.directoryPath = directoryPath;
            this.catusers = catusers;
            this.colorsUsers = colorsUsers;
            cargarLayout();
            CargarArchivosDelDirectorio(directoryPath);
        }
        private void cargarLayout()
        {
            int espacioRestante = this.ClientSize.Height - flowLayoutPanelHeader.Height;
            panelSuperior.Location = new Point(0, flowLayoutPanelHeader.Height);
            panelSuperior.Width = this.ClientSize.Width;
            panelSuperior.Height = (int)(espacioRestante * 0.80);


            panelDivisor1.Location = new Point(0, panelSuperior.Height);
            panelDivisor1.Width = this.ClientSize.Width;
            panelDivisor1.Height = 2;

            panelDivisor2.Height = 2;
            panelDivisor2.Location = new Point(0, this.ClientSize.Height - panelDivisor2.Height);
            panelDivisor2.Width = this.ClientSize.Width;

            int espacioDisponible = panelDivisor2.Top - panelDivisor1.Bottom;
            int alturaFlow = 150;

            flowLayoutPanel1.Height = alturaFlow;
            flowLayoutPanel1.Location = new Point(
                (this.ClientSize.Width - flowLayoutPanel1.Width) / 2,
                panelDivisor1.Bottom + (espacioDisponible - alturaFlow) / 2
            );
            comboBoxTipoJuegos.SelectedIndex = 0;

        }

        private void MostrarUsuariosGato(List<CatUser> usuariosGato)
        {
            panelSuperior.Controls.Clear();

            List<CatUser> usuariosOrdenados = usuariosGato;

            switch (comboBoxOrdenar.SelectedIndex)
            {
                case 0: usuariosOrdenados = usuariosGato.OrderBy(u => u.age).ToList(); break;
                case 1: usuariosOrdenados = usuariosGato.OrderByDescending(u => u.age).ToList(); break;
                case 2: usuariosOrdenados = usuariosGato.OrderBy(u => u.name).ToList(); break;
                case 3: usuariosOrdenados = usuariosGato.OrderByDescending(u => u.name).ToList(); break;
                case 4: usuariosOrdenados = usuariosGato.OrderBy(u => u.gameList.Sum(g => g.points)).ToList(); break;
                case 5: usuariosOrdenados = usuariosGato.OrderByDescending(u => u.gameList.Sum(g => g.points)).ToList(); break;
            }

            foreach (var user in usuariosOrdenados)
            {
                var uc = new CatUserControl(usuariosOrdenados, user);
                uc.setDatos(user);

                uc.OnUserDeleted += (usuarioEliminado) =>
                {
                    usuariosGato.Remove(usuarioEliminado);
                    MostrarUsuariosGato(usuariosGato);
                };
                panelSuperior.Controls.Add(uc);
            }
        }

        private void MostrarJugadoresShapes(List<ColorsUser> usuariosColors)
        {
            panelSuperior.Controls.Clear();

            List<ColorsUser> usuariosOrdenados = usuariosColors;

            switch (comboBoxOrdenar.SelectedIndex)
            {
                case 0: usuariosOrdenados = usuariosColors.OrderBy(u => u.edad).ToList(); break;
                case 1: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.edad).ToList(); break;
                case 2: usuariosOrdenados = usuariosColors.OrderBy(u => u.nombre).ToList(); break;
                case 3: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.nombre).ToList(); break;
                case 4: usuariosOrdenados = usuariosColors.OrderBy(u => u.partidas.Sum(g => g.aciertos)).ToList(); break;
                case 5: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.partidas.Sum(g => g.aciertos)).ToList(); break;
            }

            foreach (var user in usuariosOrdenados)
            {
                var uc = new ColorsUserControl();
                uc.setDatos(user, usuariosOrdenados);

                uc.OnUserDeleted += (usuarioEliminado) =>
                {
                    usuariosColors.Remove(usuarioEliminado);
                    MostrarJugadoresShapes(usuariosColors);
                };

                panelSuperior.Controls.Add(uc);
            }
        }

        private void CargarArchivosDelDirectorio(string directorio)
        {
            if (!Directory.Exists(directorio)) return;
            archivosJson = Directory.GetFiles(directorio, "*.json").ToList();

            comboBoxTipoJuegos.Items.Clear();

            foreach (var f in archivosJson)
            {
                string contenido = File.ReadAllText(f);
                JObject j = JObject.Parse(contenido);

                if (j["cat"] != null && filePathCat == null)
                {
                    filePathCat = f;
                    comboBoxTipoJuegos.Items.Add("Colorful Shapes");
                }
                else if (j["colors"] != null && filePathColors == null)
                {
                    filePathColors = f;
                    comboBoxTipoJuegos.Items.Add("Gatito Cuentagota");
                }
            }


            if (comboBoxTipoJuegos.Items.Count > 0)
                comboBoxTipoJuegos.SelectedIndex = 0;
        }


        private void comboBoxTipoJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSuperior.Controls.Clear();

            if (comboBoxTipoJuegos.SelectedIndex == 0 && catusers != null)
                MostrarUsuariosGato(catusers);
            else if (comboBoxTipoJuegos.SelectedIndex == 1 && colorsUsers != null)
                MostrarJugadoresShapes(colorsUsers);
        }



        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoJuegos.SelectedIndex == 0)
            {
                MostrarUsuariosGato(catusers);
            }
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
            {
                MostrarJugadoresShapes(colorsUsers);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoJuegos.SelectedIndex == 0)
                filePath = filePathCat;
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
                filePath = filePathColors;
            else
            {
                MessageBox.Show("No hay archivo seleccionado para renombrar.");
                return;
            }
            string nuevoNombre = Interaction.InputBox(
                "Nuevo nombre para el archivo (sin .json):",
                "Renombrar JSON",
                ""
            );

            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                nuevoNombre += ".json";

                string carpeta = Path.GetDirectoryName(filePath);
                string nuevaRuta = Path.Combine(carpeta, nuevoNombre);

                if (File.Exists(nuevaRuta))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                    return;
                }

                File.Move(filePath, nuevaRuta);
                filePath = nuevaRuta;

                MessageBox.Show("Renombrado correctamente");
            }
            else { MessageBox.Show("No puedes dejar el textbox vacio"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pathEliminar = null;

            // Determinar qué archivo eliminar según el ComboBox
            if (comboBoxTipoJuegos.SelectedIndex == 0)
                pathEliminar = filePathCat;
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
                pathEliminar = filePathColors;

            if (pathEliminar == null)
            {
                MessageBox.Show("No hay archivo seleccionado para eliminar.");
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que quieres eliminar este archivo?",
                "Eliminar JSON",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    File.Delete(pathEliminar);
                    MessageBox.Show("Archivo eliminado.");

                    // Opcional: quitar del ComboBox y actualizar paths
                    if (comboBoxTipoJuegos.SelectedIndex == 0) filePathCat = null;
                    else if (comboBoxTipoJuegos.SelectedIndex == 1) filePathColors = null;

                    comboBoxTipoJuegos.Items.RemoveAt(comboBoxTipoJuegos.SelectedIndex);
                    if (comboBoxTipoJuegos.Items.Count > 0)
                        comboBoxTipoJuegos.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string pathGuardar = null;

            if (comboBoxTipoJuegos.SelectedIndex == 0)
                pathGuardar = filePathCat;
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
                pathGuardar = filePathColors;
            else
            {
                MessageBox.Show("No hay archivo seleccionado para guardar.");
                return;
            }

            try
            {
                JObject jGuardar = new JObject();

                if (comboBoxTipoJuegos.SelectedIndex == 0)
                    jGuardar["cat"] = JArray.FromObject(catusers);
                else
                    jGuardar["colors"] = JArray.FromObject(colorsUsers);

                File.WriteAllText(pathGuardar, jGuardar.ToString());

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

    }
}
