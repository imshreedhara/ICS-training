﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy_1
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateofbirth { get; set; }

        public Student(int sId, string sName, DateTime sDOB)
        {
            id = sId;
            name = sName;
            dateofbirth = sDOB;
        }
    }
}
