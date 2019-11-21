﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tiendaOnline.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string nombreDepartamento { get; set; }
    }
}
