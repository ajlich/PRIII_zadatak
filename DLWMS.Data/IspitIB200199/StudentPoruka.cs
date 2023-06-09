﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB200199
{
    [Table("StudentiPoruke")]
    public class StudentPoruka
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public DateTime Datum { get; set; }
        public string Sadrzaj { get; set; }
        public override string ToString()
        {
            return Sadrzaj;
        }
        public byte[]? Slika { get; set; }
    }
}
