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
    [Table("Category")]
    public class Category :IAuditable
    {
     
        [Key]
        public Guid id { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        [ForeignKey("ParentId")]
        public Guid? ParentId { get; set; }
        public Category Parent { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ICollection<Product> Products { get; set; }= new HashSet<Product>();
        public ICollection<Category> ChildCategories { get; set; }
        public ICollection<role> Roles { get; set; }=new HashSet<role>();
    }
}
