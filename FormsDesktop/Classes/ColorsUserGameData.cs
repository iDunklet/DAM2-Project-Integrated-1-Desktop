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
        public int Dificulty { get; set; }
        public int Successes { get; set; }
        public int Errors { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GameTime { get; set; }
        public int Rounds { get; set; }


        //constructors
        public ColorsUserGameData(int dificulty, int successes, int errors, DateTime startDate, DateTime endDate, int gameTime, int rounds)
        {
            Dificulty = dificulty;
            Successes = successes;
            Errors = errors;
            StartDate = startDate;
            EndDate = endDate;
            GameTime = gameTime;
            Rounds = rounds;
        }


    }
}
