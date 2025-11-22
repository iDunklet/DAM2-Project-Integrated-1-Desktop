using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDesktop.Classes
{
    public class CatUser
    {
        public string name { get; set; }
        public int age { get; set; }

        public List<CatUserGameData> gameList { get; set; } = new List<CatUserGameData>();

        public CatUser(int age, string name, List<CatUserGameData> gameList)
        {
            this.age = age;
            this.name = name;
            this.gameList = gameList ?? new List<CatUserGameData>();
        }
    }
}
