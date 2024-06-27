using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        [MaxLength(100)]
        public string? picture { get; set; }
        [MaxLength(500)]
        public string intro { get; set; }
        public string? content { get; set; }
        public double ? price { get; set; }
        [ForeignKey("CategoryId")]
        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
