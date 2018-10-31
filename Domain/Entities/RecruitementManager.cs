﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RecruitementManager
    {
        [Key]
        public int idManager { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
