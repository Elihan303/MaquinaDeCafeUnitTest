using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMaquinaDeCafe
{
    public class Azucarero
    {
        public Azucarero() { }
        public Azucarero(int cant)
        {
            setCantidadDeAzucar(cant);
        }
        //variables
        public int cantidadDeAzucar;

        //metodos
        public void setCantidadDeAzucar(int cant) { cantidadDeAzucar += cant; }
        public int getCantidadDeAzucar() { return cantidadDeAzucar; }
        public bool hasAzucar(int cantidadDeAzucar)
        {
            if (cantidadDeAzucar <= getCantidadDeAzucar() )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void giveAzucar(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar -= cantidadDeAzucar;
        }
    }
}
