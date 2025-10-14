﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public class Turno
    {

        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int PeluqueroId { get; set; }

        public Peluquero Peluquero { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public int ServicioId { get; set; }

        public Servicio Servicio { get; set; }

    }
}
