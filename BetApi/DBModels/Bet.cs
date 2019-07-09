using System;
using System.Collections.Generic;

namespace BetApi.DBModels
{
    public partial class Bet
    {
        public int IdBet { get; set; }
        public int IdPlayer { get; set; }
        public DateTime DateBet { get; set; }
        public int IdSportEvent { get; set; }
        public double TypeCoef { get; set; }
        public double CoefEvent { get; set; }
        public double CountMoney { get; set; }

        public virtual Player IdPlayerNavigation { get; set; }
        public virtual SportEvent IdSportEventNavigation { get; set; }
    }
}
