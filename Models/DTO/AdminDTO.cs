namespace Migrations.Models.DTO
{
    public class AdminDTO
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public int RoleId { get; set; }
        public string UserRole { get; set; }
    }
}
