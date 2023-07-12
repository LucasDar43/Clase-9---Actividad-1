using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9___Actividad_1
{
    internal class Trabajador
    {

        protected String nombre;
        protected String apellido;
        protected double sueldo;

        public Trabajador()
        {
            nombre = "";
            apellido = "";
            sueldo = 0.0;
        }

        public Trabajador(string nombre, string apellido, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
        }

        public virtual void SetSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public virtual double GetSueldo()
        {
            return sueldo;
        }

        public virtual void SetApellido(string ape)
        {
            apellido = ape;
        }

        public virtual void SetNombre(string nom)
        {
            nombre = nom;
        }

        public virtual string GetApellido()
        {
            return apellido;
        }

        public virtual string GetNombre()
        {
            return nombre;
        }

    }
}
