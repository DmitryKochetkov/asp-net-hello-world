using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesAndRestaurants.Model
{
    [Table("city")]
    public class City
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")] 
        public string Name { get; set; }
    }
}