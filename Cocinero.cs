using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_oo_abusers
{
    // Subclase Cocinero que hereda campos y métodos innecesarios
    public class Cocinero : Empleado
    {
        public Cocinero(string nombre, decimal salario) : base(nombre, "Cocinero", salario) { }
    }
}
