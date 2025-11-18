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
        private ColorsUser currentUser;

        public ColorsUserControl()
        {
            InitializeComponent();
        }

        public void setDatos(ColorsUser user)
        {
            currentUser = user;

            labelNombre.Text = user.Name;
            labelEdad.Text = user.Age.ToString();
            panelDataGame.Controls.Clear();

            var gameListOrdenada = user.GameList.OrderBy(g => DateTime.Parse(g.EndDate.ToString())).ToList();
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


        private void ColorsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
