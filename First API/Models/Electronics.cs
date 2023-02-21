using System.ComponentModel.DataAnnotations;

namespace First_API.Models
{
    public class Electronics

    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int totalcount { get; set; }

        public int unit_price { get; set; }

        public DateTime updated_at { get; set; }



    }
}
