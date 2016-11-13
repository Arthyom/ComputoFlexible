using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace redNeuronal
{
    public class Capa
    {

        /************************************************************************************
                              propiedades publicas de la clase capa
        ************************************************************************************/
        public      int         numeroNeuronas;
        public      string      nombreRed;
        public      int         idNeurona;
        public      ArrayList   neuronas;


        /************************************************************************************
                           metodos publicas de la clase capa
        ************************************************************************************/
        public Capa( string nombCap, int idCap)
        {
            this.numeroNeuronas = 0;
            this.nombreRed = nombCap;
            this.idNeurona = idCap;     
        }

        public void AgregarNeurona ( Neurona NuevaNeurona )
        {
        }
    }
}
