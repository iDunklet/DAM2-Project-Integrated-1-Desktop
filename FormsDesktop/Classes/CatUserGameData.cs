using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDesktop.Classes
{
    public class CatUserGameData
    {
        public int gameTime { get; set; }
        public int errors { get; set; }
        public int points { get; set; }
        public string date { get; set; }
        public string dificulty { get; set; }
        public  List<float> reactionTime { get; set; }
        public CatUserGameData(string dificulty, int gameTime, int errors, int points, string date, List<float> reactiontime)
        {
            this.dificulty = dificulty;
            this.gameTime = gameTime;
            this.errors = errors;
            this.points = points;
            this.date = date;
            this.reactionTime = reactiontime;
        }
    }

}
