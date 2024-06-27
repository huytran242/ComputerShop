﻿using Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Moder
{
    [Table("Member")]
    public class Member :IAuditable
    {
        [Key]
        public Guid id { get; set; }
     
        [MaxLength(20)]
        public string name { get; set; }
        [MaxLength(100)]
        public string? picture { get; set; }

        [MaxLength(100)]
        public string? LoginName { get; set; }
        
        [MaxLength(100)]
        public string? Password { get; set; }
       
        [MaxLength(100)]
        public string Email { get; set; }
        public DateTime? LastLogin { get; set; }
        public Guid? CreatedBy { get ; set; }
        public DateTime? CreatedOn { get ; set ; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get ; set ; }
        [ForeignKey("GroupId")]
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }

    }
}
