using System;

namespace SportEventApi.DBModels
{
    public partial class SportEvent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public float Coeff1StTeam { get; set; }
        public float CoeffDraw { get; set; }
        public float Coeff2StTeam { get; set; }

        public SportEvent(int id, DateTime date, string name, float coeff1StTeam, float coeffDraw, float coeff2StTeam)
        {
            Id = id;
            Date = date;
            Name = name;
            Coeff1StTeam = coeff1StTeam;
            CoeffDraw = coeffDraw;
            Coeff2StTeam = coeff2StTeam;
        }
    }
}
