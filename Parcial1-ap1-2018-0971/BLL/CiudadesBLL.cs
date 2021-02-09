using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Parcial1_ap1_2018_0971.Entidades;
using Parcial1_ap1_2018_0971.DAL;
using System.Linq;

namespace Parcial1_ap1_2018_0971.BLL
{
    public class CiudadesBLL
    {
        public static bool Guardar(Ciudades ciudades)
        {
            if (!Existe(ciudades.CiudadId))
                return Insertar(ciudades);
            else
                return Modificar(ciudades);
        }

        private static bool Insertar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Ciudades.Add(ciudades);
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

        public static bool Modificar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(ciudades).State = EntityState.Modified;
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

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Ciudades.Any(e => e.CiudadId == id);
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

        public static bool ExisteNombre(int id, string nombres)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Ciudades.Any(e => e.Nombres == nombres);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if(encontrado)
            {
                Ciudades ciudades = Buscar(id);
                if (ciudades == null)
                    return true;

                if (ciudades.Nombres == nombres)
                    encontrado = false;
            }
            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var ciudad = contexto.Ciudades.Find(id);
                if(ciudad != null)
                {
                    contexto.Ciudades.Remove(ciudad);
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

        public static Ciudades Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ciudades ciudades;

            try
            {
                ciudades = contexto.Ciudades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ciudades;
        }
    }
}
