﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models
{
    public class TourPackageGuide
    {
        [Required]
        [ForeignKey(nameof(TourPackage))]
        public int TourPackageId { get; set; }
        [Required]
        public TourPackage TourPackage { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Guide))]
        public int GuideId { get; set; }
        [Required]
        public Guide Guide { get; set; } = null!;
    }
}