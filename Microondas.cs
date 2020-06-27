using System;

namespace ProgramacionOO
{
    class Microondas
    {

        public int Id { get; set; }
        public string Garantia { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }



        public Microondas(int id, string garantia, string marca, string modelo, double precio)
        {
            this.Id = id;
            this.Garantia = garantia;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;

        }
    }
}
