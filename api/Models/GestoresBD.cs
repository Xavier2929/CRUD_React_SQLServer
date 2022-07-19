﻿using System.ComponentModel.DataAnnotations;

namespace APIGestores.Models
{
    public class GestoresBD
    {
        [Key]
        public int id { get; set; }

        public string nombre { get; set; }

        public int lanzamiento { get; set; }
        public string desarrollador { get; set; }
    }
}