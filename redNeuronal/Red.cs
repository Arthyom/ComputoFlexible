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




        /************************************************************************************
                              metodos publicas de la clase capa
        ************************************************************************************/
        public Red() 
        {
            this.NumeroCapas = 0;
            this.NeuronasTotales = 0;
        }

        public void AgregarCapa(Neurona NuevaCapa)
        {
            this.Capas.Add(NuevaCapa);
            this.NumeroCapas++;
        }
    }
}
