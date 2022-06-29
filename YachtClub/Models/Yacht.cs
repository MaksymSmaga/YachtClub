using System.ComponentModel.DataAnnotations.Schema;

namespace YachtClub.Models
{
    // Domain Model.
    public class Yacht
    {
        // Key property
        public int YachtID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Photo { get; set; }

        // To annotate the property
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}



