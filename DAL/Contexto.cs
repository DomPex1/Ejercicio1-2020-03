using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio1_2020_03;

namespace Ejercicio1_2020_03.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> estudiantes {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Ejercicio1-2020-03.db");
        }

     }
}