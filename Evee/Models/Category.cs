using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Evee.Models
{
    public class Category
    {
        [Key]                           //Data annotations. Entity framework core will know, this "Id" is a primary key.
        public int Id { get; set; }
        [Required]                      // Data annotations: Name cannot be null.
        [MaxLength(30)]
        [DisplayName("Category Name")]  //Data annotation. Name for UI
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}



