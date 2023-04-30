using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Migrations.Models
{

    public class Proffesor : BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(10)]
        public string? Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required]

        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set;}

        public virtual Department? Department { get; set; }
    }
}
