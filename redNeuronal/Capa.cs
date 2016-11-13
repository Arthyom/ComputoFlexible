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
        public      ArrayList   Neuronas;


        /************************************************************************************
                           metodos publicas de la clase capa
        ************************************************************************************/
        public Capa( string nombCap, int idCap)
        {
            this.numeroNeuronas = 0;
            this.nombreRed = nombCap;
            this.idNeurona = idCap;
            this.Neuronas = new ArrayList();
        }

        public void AgregarNeurona ( Neurona NuevaNeurona )
        {
            this.Neuronas.Add(NuevaNeurona);
            this.numeroNeuronas++;
        }

        public void info()
        {
            Console.WriteLine("Capa -> [" + nombreRed + "] numero Neuronas -> [" + numeroNeuronas + "]");
        }
    }
}
