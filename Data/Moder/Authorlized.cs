using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("Authorlized")]
    public class Authorlized
    {
        [Key]
        public Guid id { get; set; }
        [ForeignKey("GroupId")]
        public Guid? GroupId { get; set; }
        [ForeignKey("roleId")]
        public Guid? RoleId { get; set;}
        public role? Role { get; set; }
        public Group? group { get; set; }
        public ICollection<Authorlized> Authorized { get; set; }=new HashSet<Authorlized>();
    }
}
