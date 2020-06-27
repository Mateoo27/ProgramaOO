using System;

namespace ProgramacionOO
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public Persona(int id, string nombre, string apellido, int telefono, string correo)
        {

            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Correo = correo;

        }


    }
}