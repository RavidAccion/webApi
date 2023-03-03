using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Models
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        [Required]


        
        public string category_Name { get; set; }
    }
}
