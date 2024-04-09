using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDamianPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aereo aguila = new Aereo();
            aguila.Color = "café con blanco";
            aguila.Habitat = "Montañas";
            aguila.Peso = 5;
            aguila.Alimentacion = "roedores";
            aguila.AlturaMaximaVuelo = 1000;
            aguila.NumeroAlas = 2;
            Console.WriteLine("Datos sobre el aguila");
            Console.WriteLine(aguila);
            aguila.Movimiento();
            Console.WriteLine();
           
            
            Acuatico foca = new Acuatico(50,60,"gris",50,"Aguas profundas","peces");
            Console.WriteLine("Datos sobre la foca");
            foca.Movimiento();
            foca.Nadando(5, 100);
            Console.WriteLine(foca);
           
            Console.ReadKey();

        }
    }
}
