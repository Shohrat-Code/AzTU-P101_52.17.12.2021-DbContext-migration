using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City{ get; set; }
        public List<Ad> Ads { get; set; }
    }
}
