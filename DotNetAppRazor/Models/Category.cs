using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DotNetAppRazor.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
