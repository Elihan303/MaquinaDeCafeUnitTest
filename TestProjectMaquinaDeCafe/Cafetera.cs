using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMaquinaDeCafe
{
    public class Cafetera
    {
        public Cafetera() { }
        public Cafetera(int cant) {
            setCantidaDeCafe(cant);
        }
        //variables
        int cantidadCafe;
        


        //metodos
        public void setCantidaDeCafe(int cant) { cantidadCafe += cant; }
        public int getCantidadDeCafe() { return cantidadCafe; }
        public bool hasCafe(int cantidadCafe) {
            if (cantidadCafe <= getCantidadDeCafe() )
            {
                return true;
            }
            else {
                return false;
            }
        
        }
        public void giveCafe(int cantidadCafe) {
            this.cantidadCafe -= cantidadCafe;
        }


    }
}
