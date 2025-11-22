using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsDesktop.Classes
{
    [Serializable]
    public class ColorsUserGameData
    {
        public int dificultad { get; set; }
        public int aciertos { get; set; }
        public int errores { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime fechaHoraFin { get; set; }
        public int gametime { get; set; }
        public int rondas { get; set; }

        public ColorsUserGameData(int dificulty, int successes, int errors, DateTime startDate, DateTime endDate, int gameTime, int rounds)
        {
            dificultad = dificulty;
            aciertos = successes;
            errores = errors;
            fechaHoraInicio = startDate;
            fechaHoraFin = endDate;
            gametime = gameTime;
            rondas = rounds;
        }


    }
}
