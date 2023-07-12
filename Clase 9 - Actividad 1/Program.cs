using Clase_9___Actividad_1;

namespace clas9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*utilizando clase 'trabajador'
            Trabajador trabajador = new Trabajador();

            Trabajador trabajador1 = new Trabajador();
            Trabajador trabajador2 = new Trabajador("lucas", "daran", 2000.0);

            trabajador1.SetNombre("juan");
            trabajador1.SetApellido("perez");
            trabajador1.SetSueldo(2500.0);

            Console.WriteLine("Nombre: " + trabajador1.GetNombre());
            Console.WriteLine("Apellido: " + trabajador1.GetApellido());
            Console.WriteLine("Sueldo: " + trabajador1.GetSueldo());

            Console.WriteLine("Nombre: " + trabajador2.GetNombre());
            Console.WriteLine("Apellido: " + trabajador2.GetApellido());
            Console.WriteLine("Sueldo: " + trabajador2.GetSueldo());
            */


            //utilizando clase 'jefe'
            Jefe jefe = new Jefe();

            Empleado empleado1 = new Empleado();
            empleado1.SetNombre("Luis");
            empleado1.SetApellido("Martinez");
            empleado1.SetSueldo(1500.0);

            jefe.AddEmpleado(empleado1);
            Empleado empleadoObtenido = jefe.GetEmpleado(0);
            Console.WriteLine("Nombre del empleado obtenido: " + empleadoObtenido.GetNombre());
        }

    }    
}

