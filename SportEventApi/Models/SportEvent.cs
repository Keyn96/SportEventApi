using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportEventApi.Models
{
    public class SportEvent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public float Coeff1StTeam { get; set; }
        public float CoeffDraw { get; set; }
        public float Coeff2StTeam { get; set; }
    }
}
