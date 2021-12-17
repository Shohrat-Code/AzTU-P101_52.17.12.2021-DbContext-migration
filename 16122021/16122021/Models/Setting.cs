using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        public string Phone1 { get; set; }
        [MaxLength(15)]
        public string Phone2 { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string VOEN { get; set; }
        [Column(TypeName ="ntext")]
        public string About { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [Column(TypeName = "ntext")]
        public string UserPolicy { get; set; }
        [Column(TypeName = "ntext")]
        public string Rules { get; set; }
        [Column(TypeName = "ntext")]
        public string Privacy { get; set; }
    }
}
