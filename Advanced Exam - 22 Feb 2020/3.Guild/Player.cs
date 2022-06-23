﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name,string @class)
        {
            this.Name = name;
            this.Class = @class;
            this.Rank = "Trial";
            this.Description = "n/a";
        }


        public string Name { get; private set; }

        public string Class { get; private set; }

        public string Rank { get; internal set; }

        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.AppendLine($"Description {Description}");
            return sb.ToString().Trim();
        }


    }
}
