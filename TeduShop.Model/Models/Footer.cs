using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.UI.WebControls;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { get; set; }
    }
}