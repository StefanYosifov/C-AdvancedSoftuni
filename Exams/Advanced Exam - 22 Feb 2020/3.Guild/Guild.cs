using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.roster.Count;
        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity && !roster.Any(x => x.Name == player.Name))
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                var findPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                roster.Remove(findPlayer);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                var findPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                if (findPlayer.Rank == "Member")
                {

                }
                else
                {
                    findPlayer.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                var findPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                if (findPlayer.Rank == "Trial")
                {

                }
                else
                {
                    findPlayer.Rank = "Trial";
                }
            }

        }


       public Player[] KickPlayersByClass(string @class)
       {
            List<Player> myListTemp = new List<Player>();
            foreach (var player in this.roster)
            {
                if (player.Class == @class)
                {
                    myListTemp.Add(player);
                }
            }
            Player[] myArrayToReturn = myListTemp.ToArray();

            this.roster = this.roster.Where(x => x.Class != @class).ToList();

            return myArrayToReturn;
        }

        public string Report()
        {
            string output = $"Players in the guild: {Name}";
            if (roster.Count > 0)
            {
                foreach (var player in roster)
                {
                    output +=player.ToString()+Environment.NewLine;
                }
            }
            return output.TrimEnd();
        }


    }
}
