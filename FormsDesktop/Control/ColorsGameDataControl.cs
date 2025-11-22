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
    public partial class ColorsGameDataControl : UserControl
    {
        public ColorsGameDataControl()
        {
            InitializeComponent();
        }
        public void SetDatos(ColorsUserGameData gameData)
        { String dificultad = null;
                        
            switch (gameData.dificultad)
            {
                case 1: dificultad = "fácil"; break;
                case 2: dificultad = "media"; break;
                case 3: dificultad = "difícil"; break;
            }

            labelDificultad.Text = dificultad;
            labelTiempo.Text = $"{gameData.gametime}s";
            labelErrores.Text = $"{gameData.errores}";
            labelAciertos.Text = $"{gameData.aciertos}";
            labelFecha.Text = DateTime.Parse(gameData.fechaHoraFin.ToString()).ToString("dd/MM/yyyy HH:mm");
            labelRondas.Text = $"{gameData.rondas}";
        }
    }
}
