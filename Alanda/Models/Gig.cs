using System;
using System.ComponentModel.DataAnnotations;

namespace Alanda.Models
{
    public class Gig
    {
        //add Astist here
        public int Id { get; set; }

        
        public ApplicationUser Artist { get; set; }
    
        public  string ArtistId { get; set; }
        public DateTime? DateTime { get; set; }

      
        [StringLength(255)]
        public string Vanue { get; set; }

        
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}