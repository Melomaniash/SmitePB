﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmitePB.API.Models
{
    public record Ban
    {
        public string FriendlyTeamName { get; }
        public string EnemyTeamName { get; }
        public string God { get; }

        public Ban(string friendlyTeamName, string enemyTeamName, string god)
        {
            FriendlyTeamName = friendlyTeamName;
            EnemyTeamName = enemyTeamName;
            God = god;
        }
    }
}
