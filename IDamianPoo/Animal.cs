using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDamianPoo
{
    public class Animal
    {
        public string Color { get; set; }
        public int Peso { get; set; }
        public string Habitat { get; set; }
        public string Alimentacion { get; set; }

        public Animal()
        {

        }

        public Animal(string color, int peso, string habitat, string alimentacion)
        {
            this.Color = color;
            this.Peso = peso;
            this.Habitat = habitat;
            this.Alimentacion = alimentacion;
        }

        public void Jugando()
        {
            Console.WriteLine("El animal se encuentra jugando");
        }

        public void Comiendo()
        {
            Console.WriteLine("Se encuentra comiendo");
        }

        public void Durmiendo()
        {
            Console.WriteLine("Se encuentra durmiendo");
        }

        public virtual void Movimiento()
        {
            Console.WriteLine("Se ecuentra en moviento");
        }
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Habitat: ").Append(this.Habitat).Append("\n").
            Append("Alimentacón: ").Append(this.Alimentacion).Append("\n").
            Append("Color: ").Append(this.Color).Append("\n").
            Append("Peso: ").Append(this.Peso).Append("\n");
        
            return sb.ToString();
        }

    }
}
