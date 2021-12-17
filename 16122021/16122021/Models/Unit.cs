using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
