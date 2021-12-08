﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmitePB.Domain
{
    public record Team
    {
        public string Path { get; }
        public string DisplayName { get; }
        public string Colour { get; }
        public string Logo { get; }

        public Team(string path, string displayName, string colour, string logo)
        {
            Path = path;
            DisplayName = displayName;
            Colour = colour;
            Logo = logo;
        }
    }

    public record TeamDTO
    {
        public readonly string displayName;
        public readonly string colour;

        public TeamDTO(string displayName, string colour)
        {
            this.displayName = displayName;
            this.colour = colour;
        }
    }
}
