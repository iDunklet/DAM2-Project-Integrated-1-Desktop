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
        private CatUser u;
        private List<CatUser> listaUsers;
        public event Action<CatUser> OnUserDeleted;

        public CatUserControl(List<CatUser> l, CatUser catuser)
        {
            InitializeComponent();
            this.u = catuser;
            this.listaUsers = l;
        }
        public void setDatos(CatUser user)
        {

            labelNombre.Text = user.name;
            labelEdad.Text = user.age.ToString();
            panelDataGame.Controls.Clear();

            var gameListOrdenada = user.gameList.OrderBy(g =>
            {
                string[] formats = {"yyyy-MM-ddTHH:mm:ss", "MM/dd/yyyy HH:mm:ss", "yyyy-MM-dd HH:mm:ss", "dd/MM/yyyy HH:mm:ss"};

                if (DateTime.TryParseExact(g.date, formats,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }).ToList();
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
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {u.name}?",
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
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(buttonEditar, 0, buttonEditar.Height);
        }
    }
}
