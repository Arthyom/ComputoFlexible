using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redNeuronal
{
    public partial class Form1 : Form
    {
        public Red RedNeuronalActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // crear una nueva red neuronal 
            this.RedNeuronalActual = new Red("red actual");

            // crear 3 capas para la red 
            Capa c1 = new Capa("capa 1", 0);
            Capa c2 = new Capa("capa 2", 1);
            Capa c3 = new Capa("capa 3", 2);

            // agregar capas a la red
            this.RedNeuronalActual.AgregarCapa(c1);
            this.RedNeuronalActual.AgregarCapa(c2);
            this.RedNeuronalActual.AgregarCapa(c3);

            // agregar nuevas neuronas a la capa 1 C1
            int    num = 4;
            double bias = 0.005;

            for (int i = 0; i < num; i++)
            {
                Neurona n = new Neurona( num, bias );
                c1.AgregarNeurona(n);
            }

            num = 8;
            for (int i = 0; i < num; i++)
            {
                Neurona n = new Neurona(num, bias);
                c2.AgregarNeurona(n);
            }

            num = 7;
            for (int i = 0; i < num; i++)
            {
                Neurona n = new Neurona(num, bias);
                c3.AgregarNeurona(n);
            }
            
            
            // imprimir informacion de la red
            RedNeuronalActual.info();

            c1.info();
            c2.info();
            c3.info();



        }
    }
}
