﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimpleProyecto.Models
{
    public  class CuentaClase
    {
        [Key]
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }

        public bool Activo { get; set; }    


        public int ClienteId { get; set; }

      
    }
}
