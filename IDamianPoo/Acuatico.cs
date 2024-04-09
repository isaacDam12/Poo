using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDamianPoo
{
    public class Acuatico : Animal
    {
        public int ProfundidadMaxima {get; set;}
        public int VelocidadNado { get; set;}  
        
        public int Distancia { get; set;}

        public int Companeros { get; set; }

        public Acuatico()
        {

        }

        public Acuatico(int profundidad, int velocidadNado, string color, int peso, string habitat, string alimentacion) : base(color, peso, habitat, alimentacion)
        {
            this.ProfundidadMaxima = profundidad;
            this.VelocidadNado = velocidadNado;
        }


        public string Nadando(int companeros)
        {
            this.Companeros = companeros;
            return "El animal está nadando con: " + companeros + " Compañeros de manada";
        }

        public string Nadando(int companeros, int distancia)
        {
            this.Companeros = companeros;
            this.Distancia = distancia;

            return "El animal está nadando con: " + companeros + " Compañeros de manada, una distancia total " +
                "de :" + distancia + " millas";
        }

        public override void Movimiento()
        {
            base.Movimiento();
            Console.WriteLine("sumergiendose a gran profundidad");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Profundidad Maxima de nado: ").Append(this.ProfundidadMaxima).Append('\n').
            Append("Velocidad de nado: ").Append(this.VelocidadNado).Append("\n").Append(Nadando(Companeros,Distancia));

            return sb.ToString() + base.ToString();
        }


    }
}
