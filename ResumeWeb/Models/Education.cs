﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWeb.Models
{
    public class Education
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string StopDate { get; set; }
        public bool IsContinue { get; set; }
        public string SchoolName { get; set; }
        public string Department { get; set; }
        public string Where { get; set; }
        public string Explanation { get; set; }

    }
}