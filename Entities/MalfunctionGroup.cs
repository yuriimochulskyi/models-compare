﻿using System;
using System.Collections.Generic;
using TransIT.DAL.Models.Entities.Abstractions;

namespace TransIT.DAL.Models.Entities
{
    public partial class MalfunctionGroup : IEntity
    {
        public MalfunctionGroup()
        {
            MalfunctionSubgroup = new HashSet<MalfunctionSubgroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public int? CreateId { get; set; }
        public int? ModId { get; set; }
        public virtual User Create { get; set; }
        public virtual User Mod { get; set; }
        public virtual ICollection<MalfunctionSubgroup> MalfunctionSubgroup { get; set; }
    }
}
