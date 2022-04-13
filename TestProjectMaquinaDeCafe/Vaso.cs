using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMaquinaDeCafe
{
    public class Vaso
    {
        public Vaso() { }
        public Vaso(int cant, int cont)
        {
            setCantidadVasos(cant);
            setContenido(cont);
        }

        //variables
        int cantidadVasos;
        int contenido;

        //metodos
        public void setCantidadVasos(int cant) { cantidadVasos += cant; }
        public int getCantidadVasos() { return cantidadVasos; }
        public void setContenido(int cont) { contenido += cont; }
        public int getContenido() { return contenido; }
        public bool hasVasos(int cantidadVasos)
        {
            if (cantidadVasos <= getCantidadVasos())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void giveVasos(int cantidadVasos) {
            this.cantidadVasos -= cantidadVasos; 
        }


    }
}
