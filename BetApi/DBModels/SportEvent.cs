using System;
using System.Collections.Generic;

namespace BetApi.DBModels
{
    public partial class SportEvent
    {
        public SportEvent()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public float Coeff1StTeam { get; set; }
        public float CoeffDraw { get; set; }
        public float Coeff2StTeam { get; set; }

        public virtual ICollection<Bet> Bet { get; set; }
    }
}
