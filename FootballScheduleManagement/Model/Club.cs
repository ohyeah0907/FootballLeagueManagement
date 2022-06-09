using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScheduleManagement.Model
{
    class Club
    {
        private string id;
        private string name;

        private List<Club> opponentList = new List<Club>();
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal List<Club> OpponentList { get => opponentList; set => opponentList = value; }

        public Club(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
