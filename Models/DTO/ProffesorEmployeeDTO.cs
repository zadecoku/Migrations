namespace Migrations.Models.DTO
{
    public class ProffesorEmployeeDTO
    {
        public IEnumerable<ProffesorDTO> Proffesor { get; set; }
        public IEnumerable<EmployeeDTO> Employee { get; set; }
    }
}
