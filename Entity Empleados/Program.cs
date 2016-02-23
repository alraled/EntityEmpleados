using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entity_Empleados.model;

namespace Entity_Empleados
{
    class Program
    {
        static void Main(string[] args)
        {

            var ctx = new EmpleadosEntities();
            var p = new Puesto()
            {
                nombre = "Tecnico IT",
                salarioBase = 30000
            };


            //ctx.Puesto.Add(p);





            //var ele = ctx.Puesto.Find(3);
            //foreach (var empleado in ele.Empleado)
            //{                                          // ESTO ES PARA RECORRER UNA LISTA DE TODOS LOS EMPLEADOS QUE TRABAJAN EN EL PUESTO 4 //
            //Console.WriteLine(empleado.nombre);
            //}


            //var e = new Empleado()
            //{
            // alta = DateTime.Now,
            //nombre = "Juan Gutiérrez",
            //puesto = 3                               // ESTO ES PARA AÑADIR UN ELEMENTO A LA LISTA //
            //};

            //ctx.Empleado.Add(e);



            //var ele = ctx.Puesto.Find(3);
            //if (ele != null)
            //ele.salarioBase = 45000;                 // ESTO ES PARA MODIFICAR EL PARÁMETRO DE UN ELEMENTO DENTRO DE LA TABLA //




            //var ele = ctx.Puesto.Find(1);
            //if (ele != null)                        // ESTO ES PARA ELIMINAR ALGO DE LA LISTA. EL 1 ES LA POSICIÓN DEL ELEMENTO DENTRO DE LA TABLA //
            //ctx.Puesto.Remove(ele);



            ctx.SaveChanges();                        // HASTA QUE NO SE EJECUTE ESTO, NO SE APLICARÁ NINGUNA MODIFICACIÓN EN LAS OPERACIONES ANTERIORES //



            foreach (var puesto in ctx.Puesto)

            {
                Console.WriteLine(puesto);           // ESTO ES PARA PINTAR EN LA CONSOLA TODOS LOS ELEMENTOS DE "PUESTO" EN ESTE CASO //
            }

            Console.ReadLine();
        }
    }
}


