﻿using System;
using System.Collections.Generic;

namespace TransIT.API.Models.Entities
{
    public partial class Currency
    {
        public Currency()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public int? CreateId { get; set; }
        public int? ModId { get; set; }

        public virtual User Create { get; set; }
        public virtual User Mod { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
