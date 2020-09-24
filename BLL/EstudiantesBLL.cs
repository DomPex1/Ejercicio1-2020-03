using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio1_2020_03.DAL;

namespace Ejercicio1_2020_03.BLL
{
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            if (!Existe(estudiante.EstudianteId))
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }
        public static Estudiantes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Estudiantes estudiante;

            try
            {
                estudiante = contexto.estudiantes
                    .Where(e => e.EstudianteId == id)
                    .Include(e => e.EstudiantesDetalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return estudiante;
        }
       public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var estudiante = contexto.estudiantes.Find(id);
                
                if (estudiante != null)
                {
                    contexto.estudiantes.Remove(estudiante);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.estudiantes.Any(e => e.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        private static bool Insertar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {                
                contexto.estudiantes.Add(estudiante);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM EstudiantesDetalle Where EstudianteId = {estudiante.EstudianteId}");

                foreach (var item in estudiante.EstudiantesDetalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                
                contexto.Entry(estudiante).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterio)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.estudiantes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Estudiantes> GetEstudiante()
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
