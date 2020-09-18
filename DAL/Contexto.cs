using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_2020_03
{
    public class Contexto : DbContext
    {
      
        public Contexto(DbContextOptions options) :base(options){}

        public DbSet<Estudiantes> estudiantes {get; set;}
     }
}