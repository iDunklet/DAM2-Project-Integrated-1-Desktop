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
    public partial class CatGameDataControl : UserControl
    {
        public CatGameDataControl()
        {
            InitializeComponent();
        }
        public void SetDatos(CatUserGameData gameData)
        {
            labelDificultad.Text = gameData.dificulty;
            labelTiempo.Text = $"{gameData.gameTime}s";
            labelErrores.Text = $"{gameData.errors}";
            labelPuntos.Text = $"{gameData.points}";
            labelFecha.Text = DateTime.ParseExact(
                    gameData.date,
                    "MM/dd/yyyy HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture
                ).ToString("dd/MM/yyyy HH:mm");
        }
    }
}
