using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace First_API.Models
{
    public class product
    {
        [Key]
        public int Id { get; set; }
       
        
        public string product_Name { get; set; }
        [Required]

       
        public int price { get; set; }
        public int quantity { get; set; }
        public string product_description { get; set; }


        public DateTime added_on { get; set; }

       
    }
}
