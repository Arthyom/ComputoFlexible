using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redNeuronal
{
    public class Neurona
    {

        /************************************************************************************
                              propiedades publicas de la clase neurona 
        ************************************************************************************/
        public      int         NumeroEntradas;
        public      int         numeroPesos;
        public      double     [] Entradas ;
        public      double     [] Pesos ;
        public      double     bias;
        public      double     salida;
        public      double     sumatoria;


        /************************************************************************************
                              metodos publicas de la clase neurona 
        ************************************************************************************/
        public Neurona( int numEntr, double bias )
        {
            this.NumeroEntradas = numEntr;
            this.numeroPesos = numEntr;
            this.Entradas = new double[numEntr];
            this.Pesos = new double[numEntr];
            this.bias = bias;
            this.salida = -2;
            this.sumatoria = 0;
        }

        public double funcionActivacion(string funcion)
        {
            double var =1/(1+ Math.Exp(-this.sumatoria));
            return var;
        }

        public void Sumatoria()
        {
            for (int i = 0; i < this.numeroPesos; i++)
                this.sumatoria += this.Entradas[i] * this.Pesos[i];

            this.sumatoria += this.bias;
        }

        public void Pensar(string TipoFuncion)
        {
            // hacer sumatoria de pesos 
            Sumatoria();

            // verificar cual fundion usar 
            switch (TipoFuncion)
            {
                case "funcion":
                    // activar la neurona
                    this.salida = funcionActivacion(TipoFuncion);
                break;

            }
        }





    }
}
