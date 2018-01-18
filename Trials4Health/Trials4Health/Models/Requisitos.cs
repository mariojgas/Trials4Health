﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Requisitos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Requisito { get; set; }

        public string Nome { get; set; }
        public string Descrição { get; set; }
    }
}
