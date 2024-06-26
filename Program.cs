using reto_oo_abusers;

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Mesero("Juan", 1000) { Propinas = 200 },
            new Cocinero("Carlos", 1200) { Bonos = 300 }
        };

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"{empleado.Nombre} ({empleado.Tipo}): Pago total = ${empleado.CalcularPago()}");
        }
    }
}