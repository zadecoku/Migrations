namespace Migrations.Models.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? City { get; set; }

        public string? Gender { get; set; }

        public string  DepartmentName { get; set; }
    }
}
