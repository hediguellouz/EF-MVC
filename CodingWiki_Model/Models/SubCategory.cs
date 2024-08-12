using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models
{
    [Table("SubCategories")]
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
