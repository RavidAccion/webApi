using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Models
{
    public class cat_store
    {
        [ForeignKey("stores")]
        [Key]
        public int store_id { get; set; }
       

        [ForeignKey("category")]
        public int category_id { get; set; }
    }
}
