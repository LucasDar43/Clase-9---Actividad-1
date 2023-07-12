using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9___Actividad_1
{
    internal class Jefe : Trabajador
    {

        protected List<Empleado> m_empleados;

        public Jefe()
        {
            m_empleados = new List<Empleado>();
        }

        public Jefe(List<Empleado> empleados)
        {
            m_empleados = empleados;
        }

        public void AddEmpleado(Empleado empleado)
        {
            m_empleados.Add(empleado);
        }

        public Empleado GetEmpleado(int index)
        {
            if (index >= 0 && index < m_empleados.Count)
            {
                return m_empleados[index];
            }
            else
            {
                throw new IndexOutOfRangeException("El índice está fuera de rango.");
            }
        }
    }
}
