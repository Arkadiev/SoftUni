﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models
{
    public class TourPackage
    {
        public TourPackage()
        {
            Bookings = new List<Booking>();
            TourPackagesGuides = new List<TourPackageGuide>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string PackageName { get; set; } = null!;

        [MaxLength(200)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(1, 999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        public virtual ICollection<Booking> Bookings { get; set; }

        [Required]
        public virtual ICollection<TourPackageGuide> TourPackagesGuides { get; set; }
    }
}