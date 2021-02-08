using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial1_ap1_2018_0971.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombres { get; set; }
    }
}
