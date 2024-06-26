using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_oo_abusers
{
    // Clase Empleado con campos temporales y switch statements
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; } // "Mesero" o "Cocinero"
        public decimal Salario { get; set; }
        public decimal Propinas { get; set; } // Campo temporal solo para Mesero
        public decimal Bonos { get; set; } // Campo temporal solo para Cocinero

        public Empleado(string nombre, string tipo, decimal salario)
        {
            Nombre = nombre;
            Tipo = tipo;
            Salario = salario;
        }

        public decimal CalcularPago()
        {
            switch (Tipo)
            {
                case "Mesero":
                    return Salario + Propinas;
                case "Cocinero":
                    return Salario + Bonos;
                default:
                    throw new InvalidOperationException("Tipo de empleado desconocido");
            }
        }
    }
}
