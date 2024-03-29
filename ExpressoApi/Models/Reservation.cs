﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpressoApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$",ErrorMessage ="Phone format not valid ")]
        public string  Phone { get; set; }
        [Required]
        public string  TotalPeople { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Time { get; set; }
    }
}