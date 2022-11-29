﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirstPrj.Models
{
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
    }
}