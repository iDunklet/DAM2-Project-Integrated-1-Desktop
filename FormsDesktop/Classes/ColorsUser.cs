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
        public string nombre { get; set; }
        public int edad { get; set; }
        public List<ColorsUserGameData> partidas { get; set; } = new List<ColorsUserGameData>(); // <-- fijate en los paréntesis y el ;


        //constructors
        public ColorsUser(string name, int age, List<ColorsUserGameData> gameList)
        {
            edad = age;
            nombre = name;
            partidas = gameList;
        }

    }

}
