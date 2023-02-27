using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Models
{
    public class stores
    {
        [Key]
        public int store_id { get; set; }
        [Required]
       
      public string Store_Name { get; set; }
    }
}
