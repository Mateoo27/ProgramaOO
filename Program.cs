using System;

namespace ProgramacionOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona(1765432101, "Mateo", "Beltran", 0987654321, "mateobc@gmail.com");

            Console.WriteLine($"Nro. Cedula: {persona.Id}");
            Console.WriteLine($"Nombre: {persona.Nombre} {persona.Apellido}");
            Console.WriteLine($"Nro. Celular: {persona.Telefono}");
            Console.WriteLine($"Correo: {persona.Correo}");


            Television television = new Television(123, "2 Años de Garantía", "TCL", "CP-43E", 419.99);

            Console.WriteLine("");
            Console.WriteLine($"{persona.Nombre} usted es propietario de esta television {television.Marca}, {television.Modelo}, {television.Garantia}");


            Refrigeradora refrigeradora = new Refrigeradora(112, "3 Años de Garantía", "Indurama", "R-432", 600);

            Console.WriteLine("");
            Console.WriteLine($"{persona.Nombre} {persona.Apellido} usted como propietario de la siguiente refrigeradora: {refrigeradora.Id}, {refrigeradora.Marca}, {refrigeradora.Modelo} tiene {refrigeradora.Garantia}.");


            Cocina cocina = new Cocina(981, "3 Años y Medio de Garantía", "LG", "LsG-0001", 450.65);

            Console.WriteLine("");
            Console.WriteLine($"Buenas tardes Sr. {persona.Nombre} le ofrezo esta cocina de marca {cocina.Marca}, modelo {cocina.Modelo}, que cuenta con {cocina.Garantia} y le cuesta solo {cocina.Precio}");


            Microondas microondas = new Microondas(7421, "1 Año y Medio de Garantía", "Mabe", "mC-231", 129.99);

            Console.WriteLine("");
            Console.WriteLine($"Por favor buscame cuantas unidades en stock tenemos del siguiente microondas: {microondas.Id}, {microondas.Marca}, {microondas.Modelo}, {microondas.Precio}");
            Console.WriteLine($"Señor {persona.Nombre} tenemos 5 unidades en stock de este producto");
            Console.WriteLine($"Ahora dime cuanto tiempo tienen de garantía por favor");
            Console.WriteLine($"Señor este modelo de microondas tiene {microondas.Garantia}");

        }
    }
}
