﻿using System.ComponentModel.DataAnnotations;

namespace NasaSpaceAppsDbApi.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Description { get; set; }
    }
}