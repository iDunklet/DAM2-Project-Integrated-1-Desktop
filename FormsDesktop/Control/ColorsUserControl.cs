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
using Microsoft.VisualBasic.ApplicationServices;

namespace FormsDesktop.Control
{
    public partial class ColorsUserControl : UserControl
    {
        private ColorsUser u;
        private List<ColorsUser> listaUsers;
        public event Action<ColorsUser> OnUserDeleted;

        public ColorsUserControl()
        {
            InitializeComponent();
        }
        public void setDatos(ColorsUser user, List<ColorsUser> listaUsers)
        {
            u = user;
            this.listaUsers = listaUsers;


            labelNombre.Text = u.nombre;
            labelEdad.Text = u.edad.ToString();
            panelDataGame.Controls.Clear();

            var gameListOrdenada = u.partidas.OrderBy(g => DateTime.Parse(g.fechaHoraFin.ToString())).ToList();
            int yPosition = 10;
            foreach (var gameData in gameListOrdenada)
            {
                var gameControl = new ColorsGameDataControl();
                gameControl.Location = new Point(10, yPosition);
                gameControl.SetDatos(gameData);
                panelDataGame.Controls.Add(gameControl);
                yPosition += gameControl.Height + 10;
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(buttonEditar, 0, buttonEditar.Height);
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {u.nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                listaUsers.Remove(u);
                OnUserDeleted?.Invoke(u);
            }
        }
    }
}
