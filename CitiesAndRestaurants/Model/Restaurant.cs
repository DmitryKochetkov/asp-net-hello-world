using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesAndRestaurants.Model
{
    [Table("restaurant")]
    public class Restaurant
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; } 
        
        [Column("city_id")]
        [ForeignKey("city")]
        public long City { get; set; }
    }
}