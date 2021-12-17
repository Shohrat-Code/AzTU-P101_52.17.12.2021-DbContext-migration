using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Models
{
    public class Ad 
    {
        [Key]
        public int Id { get; set; }
        public decimal Capacity { get; set; }
        public short Year { get; set; }
        public int KM { get; set; }
        public decimal Price { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal EnginePower { get; set; }
        public bool IsNew { get; set; }
        public bool ABS { get; set; }
        public bool ClimateControl { get; set; }
        [Column(TypeName ="ntext")]
        public string Description { get; set; }
        [MaxLength(250)]
        public string FrontImage { get; set; }
        [MaxLength(250)]
        public string BackImage { get; set; }
        [MaxLength(250)]
        public string PanelImage { get; set; }
        public bool Barter { get; set; }
        public bool Kredit { get; set; }
        [ForeignKey("Model")]
        public int ModelId { get; set; }
        public Model Model { get; set; }
        [ForeignKey("Transmission")]
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }
        [ForeignKey("DriveUnit")]
        public int DriveUnitId { get; set; }
        public DriveUnit DriveUnit { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [ForeignKey("BanType")]
        public int BanTypeId { get; set; }
        public BanType BanType{ get; set; }
        [ForeignKey("FuelType")]
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }
        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public List<AdImage> AdImages { get; set; }
    }
}
