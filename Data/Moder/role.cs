using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("Role")]
    public class role
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? code { get; set; }
        [ForeignKey("CategoryId")]
        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
