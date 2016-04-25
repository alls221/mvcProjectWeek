﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectWeek.Models
{
    public class Tops // class for tops
    {
        [Key] // creates unique idenitifier
        public int TopsId { get; set; }
        public string Photo { get; set; }
        public string Nickname { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}