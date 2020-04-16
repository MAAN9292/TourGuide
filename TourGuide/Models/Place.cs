using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourGuide.Models
{
    public class Place
    {
        [Key]
        public int PlaceID { get; set; }

        [Required]
        [StringLength(300)]
        public string PlaceName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CountryID { get; set; }

        public Country Country { get; set; }

        public ICollection<Photo> Photos { get; set; }

    }
}
