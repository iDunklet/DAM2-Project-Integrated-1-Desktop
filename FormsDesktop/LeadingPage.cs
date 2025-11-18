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
using Microsoft.VisualBasic.ApplicationServices;

namespace FormsDesktop
{
    public partial class LeadingPage : Form
    {

        private List<ColorsUser> listColors = null;
        private List<CatUser> listCat = null;

        public LeadingPage(List<ColorsUser> lco, List<CatUser> lca)
        {
            InitializeComponent();
            this.listCat = lca;
            this.listColors = lco;
            cargarLayout();
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


        private List<ColorsUser> datosShapePrueba()
        {
            List<ColorsUser> jugadores = new List<ColorsUser>
            {
                new ColorsUser("María", 20, new List<ColorsUserGameData>
                {
                    new ColorsUserGameData(1, 300, 12, DateTime.Parse("2025-11-11T16:00:00"), DateTime.Parse("2025-11-11T16:18:00"), 980, 4),
                    new ColorsUserGameData(2, 250, 8, DateTime.Parse("2025-11-12T10:00:00"), DateTime.Parse("2025-11-12T10:20:00"), 1200, 5)
                }),
                new ColorsUser("Carlos", 25, new List<ColorsUserGameData>
                {
                    new ColorsUserGameData(1, 150, 2, DateTime.Parse("2025-11-10T14:00:00"), DateTime.Parse("2025-11-10T14:15:00"), 950, 3),
                    new ColorsUserGameData(2, 380, 6, DateTime.Parse("2025-11-12T09:30:00"), DateTime.Parse("2025-11-12T09:55:00"), 1650, 6)
                }),
                new ColorsUser("Pepa", 22, new List<ColorsUserGameData>
                {
                    new ColorsUserGameData(2, 420, 8, DateTime.Parse("2025-11-13T18:45:00"), DateTime.Parse("2025-11-13T19:15:00"), 1850, 7),
                    new ColorsUserGameData(1, 95, 0, DateTime.Parse("2025-11-11T09:20:00"), DateTime.Parse("2025-11-11T09:35:00"), 1500, 3)
                }),
                new ColorsUser("Lucía", 28, new List<ColorsUserGameData>
                {
                    new ColorsUserGameData(1, 200, 4, DateTime.Parse("2025-11-13T09:15:00"), DateTime.Parse("2025-11-13T09:35:00"), 780, 4),
                    new ColorsUserGameData(2, 450, 15, DateTime.Parse("2025-11-12T17:45:00"), DateTime.Parse("2025-11-12T18:15:00"), 1100, 6)
                }),
                new ColorsUser("Juan", 30, new List<ColorsUserGameData>
                {
                    new ColorsUserGameData(2, 500, 10, DateTime.Parse("2025-11-15T16:00:00"), DateTime.Parse("2025-11-15T16:32:00"), 1950, 8),
                    new ColorsUserGameData(1, 110, 0, DateTime.Parse("2025-11-13T10:45:00"), DateTime.Parse("2025-11-13T11:05:00"), 1600, 5)
                })
            };

            return jugadores;
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
                var uc = new CatUserControl();
                uc.setDatos(user);
                uc.EditarClick += (s, ev) => MessageBox.Show($"EDITAR usuario: {user.name}");
                uc.EliminarClick += (s, ev) => MessageBox.Show($"ELIMINAR usuario: {user.name}");
                panelSuperior.Controls.Add(uc);
            }
        }

        private void MostrarJugadoresShapes(List<ColorsUser> usuariosColors)
        {
            panelSuperior.Controls.Clear();

            List<ColorsUser> usuariosOrdenados = usuariosColors;

            switch (comboBoxOrdenar.SelectedIndex)
            {
                case 0: usuariosOrdenados = usuariosColors.OrderBy(u => u.Age).ToList(); break;
                case 1: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.Age).ToList(); break;
                case 2: usuariosOrdenados = usuariosColors.OrderBy(u => u.Name).ToList(); break;
                case 3: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.Name).ToList(); break;
                case 4: usuariosOrdenados = usuariosColors.OrderBy(u => u.GameList.Sum(g => g.Successes)).ToList(); break;
                case 5: usuariosOrdenados = usuariosColors.OrderByDescending(u => u.GameList.Sum(g => g.Successes)).ToList(); break;
            }

            foreach (var user in usuariosOrdenados)
            {
                var uc = new ColorsUserControl();
                uc.setDatos(user);
                panelSuperior.Controls.Add(uc);
            }
        }
        private void comboBoxTipoJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSuperior.Controls.Clear();

            if (comboBoxTipoJuegos.SelectedIndex == 0)
            {
                MostrarUsuariosGato(listCat);
            }
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
            {
                MostrarJugadoresShapes(listColors);
            }
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoJuegos.SelectedIndex == 0)
            {
                MostrarUsuariosGato(listCat);
            }
            else if (comboBoxTipoJuegos.SelectedIndex == 1)
            {
                MostrarJugadoresShapes(listColors);
            }
        }

    }
}
