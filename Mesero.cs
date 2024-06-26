using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_oo_abusers
{
    // Subclase Mesero que hereda campos y métodos innecesarios
    public class Mesero : Empleado
    {
        public Mesero(string nombre, decimal salario) : base(nombre, "Mesero", salario) { }
    }
}
