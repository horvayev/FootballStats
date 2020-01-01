using System;

namespace Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
    }
}