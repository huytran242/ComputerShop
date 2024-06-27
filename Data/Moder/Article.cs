using Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("Article")]
    public class Article :IAuditable,IMeta
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [MaxLength(100)]
        public string title { get; set; } = "";
        [MaxLength(100)]
        public string? picture { get; set; }
        [MaxLength(500)]
        public string intro { get; set; }
        public string? content { get; set; }
        public Guid? CreatedBy { get ; set ; }
        public DateTime? CreatedOn { get ; set; }
        public Guid? ModifiedBy { get ; set ; }
        public DateTime? ModifiedOn { get ; set; }
        public string? Keyword { get ; set ; }
        public string? Description { get ; set ; }

    }
}
