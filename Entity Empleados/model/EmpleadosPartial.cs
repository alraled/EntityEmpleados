using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Empleados.model
{
    public partial class Puesto
    {
        public override string ToString()
        {
            return $"{nombre} {salarioBase}";            // ESTO ES PARA MODIFICAR LA CLASE QUE TE GENERA EL CÓDIGO Y QUE AL ACTUALIZAR NO SE TE ELIMINE //
        }
    }


}
