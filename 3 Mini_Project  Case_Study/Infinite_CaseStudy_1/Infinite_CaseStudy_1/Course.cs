﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy_1
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
        public float fees { get; set; }

        public Course(int id, string name, string duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }
    }
}
