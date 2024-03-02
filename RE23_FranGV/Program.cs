namespace RE23_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // RECURSOS

            Programador Juan;

            ProgramadorJunior Raul;

            // INICIALIZACIÓN

            Juan = new Programador("Juan", "Perez", 1000);

            Raul = new ProgramadorJunior("Raul", "Jimenez", 2000, 1000);

            // ENTRADA

            Juan.Salario = Interfaz.SolicitarNum();

            // PROCESO



            // SALIDA

            Console.WriteLine($"Salario: {Juan.Salario}\nNombre: {Juan.Nombre}\nApellidos: {Juan.Apellidos}");

            Console.WriteLine($"\nSalario: {Raul.Salario}\nNombre: {Raul.Nombre}\nApellidos: {Raul.Apellidos}\nBonus: {Raul.Bonus}");


        }
    }
}
