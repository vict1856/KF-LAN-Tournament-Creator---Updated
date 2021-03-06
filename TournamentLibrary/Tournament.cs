﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class Tournament
    {
        private string name;
        List<Team> teams = new List<Team>();
        List<Round> rounds = new List<Round>();


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void AddRound(Round round)
        {
            rounds.Add(round);
        }
    }
}
