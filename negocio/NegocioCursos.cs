using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class NegocioCursos
    {
        public void agregarMateriaCurso(Cursos nuevoCurso, Materias asignoMateria, Carreras asignoCarrera)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Cursos Values(@nombre, @expedienteCarrera, @idMateria)");
                datos.setearParametro("@nombre",nuevoCurso.Nombre);
                datos.setearParametro("@expedienteMateria", asignoCarrera.Expediente);
                datos.setearParametro("@idMateria", asignoMateria.IdMateria);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
