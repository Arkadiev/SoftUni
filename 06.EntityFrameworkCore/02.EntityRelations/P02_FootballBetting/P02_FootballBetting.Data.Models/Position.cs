﻿using P02_FootballBetting.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Position
    {
        public Position()
        {
            Players = new HashSet<Player>();
        }
        [Key]
        public int PositionId { get; set; }

        [MaxLength(ValidationConstants.PositionNameMaxLength)]
        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Player> Players { get; set; }
    }
}
