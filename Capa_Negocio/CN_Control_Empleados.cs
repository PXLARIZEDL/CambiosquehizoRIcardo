using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Conexion;

namespace Capa_Negocio
{
    public class  CN_Control_Empleados : ICapa_de_Negocio
    {
        private CD_Empleados objetoCD = new CD_Empleados();

        public DataTable Mostrar()
        {
            return objetoCD.Mostrar();
        }

        public void Insertar(string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            objetoCD.Insertar(nombre, apellido, cedula, correo, fechanacimiento, cargo, telefono, fechaingreso, iddepartamento, iddireccion, genero);
        }

        public void Editar(int id, string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            objetoCD.Editar(id, nombre, apellido, cedula, correo, fechanacimiento, cargo, telefono, fechaingreso, iddepartamento, iddireccion, genero);
        }

        public void Eliminar(int id)
        {
            objetoCD.Eliminar(id);
        }
    }
}
