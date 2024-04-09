using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDamianPoo
{
    public class Aereo : Animal
    {
        public int NumeroAlas {get; set;}
        public int AlturaMaximaVuelo { get; set;}


        public Aereo()
        {

        }

        public Aereo(int numeroAlas, int alturaMaxima) {
            this.NumeroAlas = numeroAlas;
            this.AlturaMaximaVuelo = alturaMaxima;
        }


        public override void Movimiento()
        {
            base.Movimiento();
            Console.WriteLine("Está decendiendo en picada");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numero Alas: ").Append(this.NumeroAlas).Append('\n').
            Append("Altura Maxima: ").Append(this.AlturaMaximaVuelo);

            return base.ToString() + sb.ToString();
       
        }
    }
}
