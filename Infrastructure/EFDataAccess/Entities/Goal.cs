namespace Infrastructure.EFDataAccess.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public bool OwnGoal { get; set; }
        public int GoalTime { get; set; }        
    }
}