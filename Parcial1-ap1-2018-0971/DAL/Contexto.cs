using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Parcial1_ap1_2018_0971.Entidades;

namespace Parcial1_ap1_2018_0971.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionCiudades.Db");
        }
    }
}
