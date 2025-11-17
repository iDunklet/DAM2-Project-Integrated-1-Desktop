using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsDesktop.Classes
{
    [Serializable]
    public class ColorsUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<ColorsUserGameData> GameList { get; set; } = new List<ColorsUserGameData>(); // <-- fijate en los paréntesis y el ;


        //constructors
        public Jugador(string name, int age, List<ColorsUserGameData> gameList)
        {
            Age = age;
            Name = name;
            GameList = gameList;
        }

    }

}
