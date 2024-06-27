using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("group")]
    public class Group
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [StringLength(100)]
        public string? name { get; set; }
        public ICollection<Member> members { get; set; }=new HashSet<Member>();
        public ICollection<Authorlized> Authorlizeds { get; set; } =new HashSet<Authorlized>();
    }
}
