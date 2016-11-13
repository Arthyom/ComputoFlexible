using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace redNeuronal
{
    public class Red
    {

        /************************************************************************************
                             propiedades publicas de la clase capa
        ************************************************************************************/
        public int          NumeroCapas;
        public int          NeuronasTotales;
        public ArrayList    Capas;
        public string       NombreRed;




        /************************************************************************************
                              metodos publicas de la clase capa
        ************************************************************************************/
        public Red( string nomRed ) 
        {
            this.NumeroCapas = 0;
            this.NeuronasTotales = 0;
            this.NombreRed = nomRed;
            this.Capas = new ArrayList();
        }

        public void AgregarCapa(Capa NuevaCapa)
        {
            this.Capas.Add(NuevaCapa);
            this.NumeroCapas++;
        }

        public void info()
        {
            Console.WriteLine("Red -> ["+ NombreRed + "] numero Capas ->[" + NumeroCapas+"]");
        }
    }
}
