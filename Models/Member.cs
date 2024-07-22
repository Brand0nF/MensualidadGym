using System.ComponentModel.DataAnnotations;

namespace MensualidadGym.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Rut { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }
        
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}
