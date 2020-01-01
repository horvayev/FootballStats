namespace Infrastructure.EFDataAccess.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int TeamId { get; set; }
        public int KitNumber { get; set; }
    }
}