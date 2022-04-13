using NUnit.Framework;

namespace TestProjectMaquinaDeCafe
{
    //Class Vaso

    public class TestVaso
    {
        [Test]
        public void deberiaDevolverVCerdaderoSiExisteVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);
            bool resultado = vasosPequenos.hasVasos(1);
            Assert.AreEqual(true, resultado);
        }
        [Test]
        public void deberiaDevolverFalsosSiNoExistenVasos()
        {
            Vaso vasosPequeno = new Vaso(1, 10);
            bool resultado = vasosPequeno.hasVasos(2);
            Assert.AreEqual(false, resultado);
        }
        [Test]
        public void deberiaRestarCantidadDeVaso()
        {
            Vaso vasosPequeno = new Vaso(5, 10);
            vasosPequeno.giveVasos(1);
            Assert.AreEqual(4, vasosPequeno.getCantidadVasos());
        }
    }
    //Class Cafetera
    public class TestCafetera
    {
        [Test]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.AreEqual(true, resultado);
        }
        [Test]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.AreEqual(false, resultado);
        }
        [Test]
        public void deberiaRestarCafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadDeCafe());
        }
        //Class Azucarero
        public class TestAzucarero
        {
            Azucarero azucarero;

            [SetUp]
            public void Setup()
            {
                azucarero = new Azucarero(10);
            }
            [Test]
            public void deberiadevolverVerdaderoSiHaySuficienteAzucarEnElAzucarero()
            {
                bool resultado = azucarero.hasAzucar(5);
                Assert.AreEqual(true, resultado);
                resultado = azucarero.hasAzucar(10);
                Assert.AreEqual(true, resultado);
            }
            [Test]
            public void deberiadevolverFalsoPorqueNoHaySuficienteAzucarEnElAzucarero()
            {
                bool resultado = azucarero.hasAzucar(15);
                Assert.AreEqual(false, resultado);
            }

            [Test]
            public void deberiaRestarAzucarAlAzucarero()
            {
                azucarero.giveAzucar(5);
                Assert.AreEqual(5, azucarero.getCantidadDeAzucar());
                azucarero.giveAzucar(2);
                Assert.AreEqual(3, azucarero.getCantidadDeAzucar());
            }
           

        }
    }





















    public class Tests
    {
        Cafetera cafetera;
        Vaso vasosPequeno;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azucarero;
        MaquinaDeCafe maquinaDeCafe;


        [SetUp]
        public void Setup()
        {

            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 3);
            vasosMediano = new Vaso(5, 5);
            vasosGrande = new Vaso(5, 7);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setVasosPequeno(vasosPequeno);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);


        }

        [Test]
        public void deberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            Assert.AreEqual(maquinaDeCafe.vasosPequeno, vaso);
        }
        [Test]
        public void deberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinaDeCafe.vasosMedianos, vaso);
        }
        [Test]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinaDeCafe.vasosGrandes, vaso);
        }

        [Test]
        public void deberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [Test]
        public void deberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(2);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay Cafe", resultado);
        }
        [Test]
        public void deberiaDevolverNoHayAzucar()
        {
            cafetera = new Cafetera(10);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 4);
            Assert.AreEqual("No hay Azucar", resultado);

        }
        [Test]
        public void deberiaRestarCafe()
        {
            cafetera = new Cafetera(25);
            maquinaDeCafe.setCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getCafetera();
            Assert.AreEqual(22, resultado);
        }
        [Test]
        public void deberiaRestarVaso()
        {
            cafetera = new Cafetera(20);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = vasosPequeno.getCantidadVasos();
            Assert.AreEqual(4, resultado);
        }
        [Test]
        public void deberiaRestarAzucar() {
            cafetera = new Cafetera(20);
            maquinaDeCafe.setCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 5);
            int resultado = azucarero.getCantidadDeAzucar();
            Assert.AreEqual(15, resultado);
        }  

    }
}