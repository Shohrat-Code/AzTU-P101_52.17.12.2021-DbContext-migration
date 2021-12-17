using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Models
{
    public class AdImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [ForeignKey("Ad")]
        public int AdId { get; set; }
        public Ad Ad { get; set; }
    }
}
