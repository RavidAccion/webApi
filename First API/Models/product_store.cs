using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Models
{
    public class product_store
    {
        [ForeignKey("product")]
        [Key]
        public int product_id { get; set; }

        [ForeignKey("category")]
      
        public int category_id { get; set; }
    }
}
