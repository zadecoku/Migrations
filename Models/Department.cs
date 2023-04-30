namespace Migrations.Models
{
    public class Department:BaseEntity
    {
        public new int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Proffesor>? Proffesor { get;}
    }

}
