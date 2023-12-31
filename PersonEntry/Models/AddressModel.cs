﻿
using System.ComponentModel.DataAnnotations;

namespace PersonEntry.Models
{
    public class AddressModel
    {
        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public string FullAddress => $"{Street} {City}, {State} {ZipCode}";
    }
}
