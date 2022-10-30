using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [StringLength(20)]
        [Column(TypeName ="varchar")]
        [Required]
        public string MovieName { get; set; }
        public string lang { get; set; }
        public string actor { get; set; }
        public string director { get; set; }
        public int releaseYear { get; set; }
    }
}
