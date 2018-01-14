using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    [Table("pon13_228108_A")]
    public class Article
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
