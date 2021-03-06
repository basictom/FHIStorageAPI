﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FHIStorage.API.Models;

namespace FHIStorage.API.Entities
{
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HouseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        public string Town { get; set; }
        [Required]
        public Decimal ContractedPrice { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime? DateSold { get; set; }
        public bool Sold { get; set; }
        public string PointOfContact { get; set; }
        public string Notes { get; set; }
    }
}
