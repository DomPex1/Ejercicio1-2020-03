using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio1_2020_03;

namespace Ejercicio1_2020_03.BLL
{
    public class EstudiantesBLL
    {

        private Contexto _contexto;

        public EstudiantesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Estudiantes estudiante)
        {
            if (!Existe(estudiante.EstudianteId))
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }
        public Estudiantes Buscar(int id)
        {
            Estudiantes estudiante;

            try
            {
                estudiante = _contexto.estudiantes.Find(id);
                   
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return estudiante;
        }
       public bool Eliminar(int id)
        {
            bool paso = false;
          
            try
            {
                var estudiante = _contexto.estudiantes.Find(id);
                
                if (estudiante != null)
                {
                    _contexto.estudiantes.Remove(estudiante);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               _contexto.Dispose();
            }

            return paso;
        }
        public  bool Existe(int id)
        {
           ;
            bool encontrado = false;

            try
            {
                encontrado = _contexto.estudiantes.Any(e => e.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               _contexto.Dispose();
            }

            return encontrado;
        }

        private  bool Insertar(Estudiantes estudiante)
        {
            bool paso = false;
            

            try
            {
                _contexto.estudiantes.Add(estudiante);
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return paso;
        }
        public bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
 

            try
            {
                _contexto.Database.ExecuteSqlRaw($"Delete FROM EstudiantesDetalle Where EstudianteId = {estudiante.EstudianteId}");

                foreach (var item in estudiante.EstudiantesDetalle)
                {
                    _contexto.Entry(item).State = EntityState.Added;
                }
                _contexto.Entry(estudiante).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               _contexto.Dispose();
            }
            return paso;
        }

    }
}
