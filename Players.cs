using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ize
{
    public record Players
    {
        public string Name { get; init; }
        
        public string Nationality { get; init; }

        private int BirthYear { get; init; }
        private string Team { get; set; }

        protected int Goals { get; set; }
        protected int Matches { get; set; }

        public Players(string name, string nationality, int birthYear, string team, int goals, int matches)
        {
            Name = name;
            Nationality = nationality;
            BirthYear = birthYear;
            Team = team;
            Goals = goals;
            Matches = matches;
        }

        public void MatchG(int g)
        {
            Matches++;
            Goals += g;
        }
        public double AG()
        {
            return (double)Goals / Matches;
        }

        private bool TRa()
        {
            return Matches >= 10;
        }
        public bool TRaTO(string newT)
        {
            if (TRa())
            {
                Team = newT;
                return true;
            }
            return false;   
        }

        public override string ToString()
        {
            return $"Name: {Name}, Nationality: {Nationality}, Birth Year: {BirthYear}, Team: {Team}, Goals: {Goals}, Matches: {Matches}";
        }

    }
}
