﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bd
{
    public abstract class ProduccionAcademica
    {
        public string Titulo { get; set; }
        public ProduccionAcademica (string titulo)
        {
            Titulo = titulo;
        }
    }
}