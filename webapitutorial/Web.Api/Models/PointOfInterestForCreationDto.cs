﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Models
{
    public class PointOfInterestForCreationDto
    {

        [Required(ErrorMessage = "Name is missing")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

    }
}
