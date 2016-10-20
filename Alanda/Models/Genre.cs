using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alanda.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}