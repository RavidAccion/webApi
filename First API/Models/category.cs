using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Models
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        [Required]


        [ForeignKey("stores")]
        public int  store_id { get; set; }
        public string category_Name { get; set; }
    }
}
