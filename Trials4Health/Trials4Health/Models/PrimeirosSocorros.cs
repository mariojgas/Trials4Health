﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class PrimeirosSocorros
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID_SOS { get; set; }

        public string Nome { get; set; }
        public string Descriçao { get; set; }
        public string Tecnicas { get; set; }
    }
}
