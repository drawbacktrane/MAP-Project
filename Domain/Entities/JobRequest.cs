﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobRequest
    {
        [Key]
        public int IdRequest { get; set; }
        public String Status { get; set; }
        public DateTime RequestDate { get; set; }
        public virtual ICollection<JobSeeker> JobSeekers { get; set; }
    }
}
