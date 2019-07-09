using System;
using System.Collections.Generic;

namespace BetApi.DBModels
{
    public partial class Player
    {
        public Player()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string HashPassword { get; set; }
        public double Balance { get; set; }

        public virtual ICollection<Bet> Bet { get; set; }
    }
}
