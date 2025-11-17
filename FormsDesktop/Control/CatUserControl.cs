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

namespace FormsDesktop.Control
{
    public partial class CatUserControl : UserControl
    {
        public event EventHandler EditarClick;
        public event EventHandler EliminarClick;
        private CatUser currentUser;

        public CatUserControl()
        {
            InitializeComponent();
        }

        public void setDatos(CatUser user)
        {
            currentUser = user;

            labelNombre.Text = user.Name;
            labelEdad.Text = user.Age.ToString();
            panelDataGame.Controls.Clear();

            var gameListOrdenada = user.GameList.OrderBy(g => DateTime.Parse(g.Date)).ToList();
            int yPosition = 10;
            foreach (var gameData in gameListOrdenada)
            {
                var gameControl = new CatGameDataControl();
                gameControl.Location = new Point(10, yPosition);
                gameControl.SetDatos(gameData);
                panelDataGame.Controls.Add(gameControl);
                yPosition += gameControl.Height + 10;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarClick?.Invoke(this, EventArgs.Empty);
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarClick?.Invoke(this, EventArgs.Empty);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(buttonEditar, 0, buttonEditar.Height);
        }

        private void labelEdad_Click(object sender, EventArgs e)
        {

        }
    }
}
