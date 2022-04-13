using System;

namespace TestProjectMaquinaDeCafe
{
    public class MaquinaDeCafe
    {

        //creado objeto
        public Cafetera cafe;
        public Vaso vasosPequeno;
        public Vaso vasosMedianos;
        public Vaso vasosGrandes;
        public Azucarero azucar;
        //metodos

        public void setVasosPequeno(Vaso vaso)
        {
            vasosPequeno = vaso;
        }
        public void setVasosMediano(Vaso vaso)
        {
            vasosMedianos = vaso;
        }
        public void setVasosGrande(Vaso vaso)
        {
            vasosGrandes = vaso;
        }
        public void setAzucarero(Azucarero azucarero)
        {
            azucar = azucarero;
        }
        public int getCafetera()
        {
            return cafe.getCantidadDeCafe();
        }
        public void setCafetera(Cafetera caf)
        {
            cafe = caf;
        }


        public Vaso getTipoVaso(string tipoDeVaso)
        {
            if (tipoDeVaso == "pequeno")
            {
                return vasosPequeno;
            }
            else if (tipoDeVaso == "mediano")
            {
                return vasosMedianos;
            }
            else
            {
                return vasosGrandes;
            }


        }


        public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (tipoDeVaso == vasosPequeno)
            {
                if (cantidadDeVasos >= vasosPequeno.getCantidadVasos())
                {
                    return "No hay Vasos";
                }
                else
                {
                    vasosPequeno.giveVasos(cantidadDeVasos);
                }
                if (cafe.getCantidadDeCafe() < 3)
                {
                    return "No hay Cafe";
                }
                else
                {
                    cafe.giveCafe(3 * cantidadDeVasos);
                }
                if (cantidadDeAzucar > azucar.getCantidadDeAzucar())
                {
                    return "No hay Azucar";

                }
                else
                {
                    azucar.giveAzucar(cantidadDeAzucar);

                }

            }
            if (tipoDeVaso == vasosMedianos)
            {
                if (cantidadDeVasos >= vasosMedianos.getCantidadVasos())
                {
                    return "No hay Vasos";
                }
                else
                {
                    vasosMedianos.giveVasos(cantidadDeVasos);
                }

                if (cafe.getCantidadDeCafe() < 5)
                {

                    return "No hay Cafe";
                }
                else
                {
                    cafe.giveCafe(5 * cantidadDeVasos);
                }

                if (cantidadDeAzucar > azucar.getCantidadDeAzucar())
                {
                    return "No hay Azucar";
                }
                else
                {
                    azucar.giveAzucar(cantidadDeAzucar);

                }
            }
            if (tipoDeVaso == vasosGrandes)
            {
                if (cantidadDeVasos >= vasosGrandes.getCantidadVasos())
                {
                    return "No hay Vasos";
                }
                else
                {
                    vasosGrandes.giveVasos(cantidadDeVasos);
                }
                if (cafe.getCantidadDeCafe() < 7)
                {
                    return "No hay Cafe";
                }
                else
                {
                    cafe.giveCafe(7 * cantidadDeVasos);
                }
                if (cantidadDeAzucar > azucar.getCantidadDeAzucar())
                {
                    return "No hay Azucar";
                }
                else
                {
                    azucar.giveAzucar(cantidadDeAzucar);

                }
            }
            return "No funciono";



        }


    }



}
